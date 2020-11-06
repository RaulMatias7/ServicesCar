using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicesCars.Models;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;


namespace ServicesCars.Operations
{
    public class optClientes
    {
        ////: vetor[0] indica falso e retornara uma mensagem
        ////: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, "good" };

        //: SELECIONAR ELEMENTOS
        public async Task Get(DataGridView dgv)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    var take = await db.Funcionarios.AsNoTracking().Select(x => new
                    {
                      /*0*/  x.id,
                      /*1*/  x.nome,
                      /*2*/  x.username,
                      /*3*/  x.sexo,
                      /*4*/  data = x.dataN,
                      /*5*/  x.senha,
                      /*6*/  x.estado,
                      /*7*/  x.acesso,
                      /*8*/  criação = x.data_criacao,
                      /*9*/  modificação = x.data_modificacao
                    }).OrderBy(x => x.nome).ToListAsync();


                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public async Task GetBySearch(DataGridView dgv,string search)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    var take = await (from x in db.Funcionarios
                                      where x.nome.Contains(search) || x.sexo.Contains(search) || x.estado.Contains(search)
                                      orderby x.nome ascending
                                      select new
                                      {
                                          x.id,
                                          x.nome,
                                          x.username,
                                          x.sexo,
                                          data = x.dataN,
                                          x.senha,
                                          x.estado,
                                          x.acesso,
                                          criação = x.data_criacao,
                                          modificação = x.data_modificacao
                                      }).ToListAsync();

                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //: ADICIONAR ELEMENTO
        public string Add(Funcionarios funcionarios)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(funcionarios.nome))
                {
                    return vetor[0] = "Insira o nome do funcionario a ser adicionado";
                }

                funcionarios.data_criacao = DateTime.Now;
                funcionarios.estado = "Habilitado";
                funcionarios.data_modificacao = null;
                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Funcionarios.Add(funcionarios);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível adicionar este funcionario";

                        transation.Commit();
                        vetor[0] = "Funcionário adicionado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível adicionar este funcionário \n Erro:" + ms.Message;
            }
        }

        ////: Editar ELEMENTO
        public async Task<string> Update(Funcionarios funcionarios)
        {
            try
            {
                if (funcionarios.id == 0)
                {
                    return vetor[0] = "Selecione o funcionário para pegar o número de idenfificação (ID).";
                }
                if (string.IsNullOrWhiteSpace(funcionarios.nome))
                {
                    return vetor[0] = "Insira o nome do funcionario a ser editado";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Funcionarios.AsNoTracking().FirstOrDefaultAsync(x => x.id == funcionarios.id);

                        if (take is null)
                            return vetor[0] = "O funcionário selecionado não foi encontrado";

                        //subServicos.id = id;
                        funcionarios.data_criacao = take.data_criacao;
                        funcionarios.data_modificacao = DateTime.Now;
                        funcionarios.username = take.username;
                        funcionarios.senha = take.senha;
                        funcionarios.estado = take.estado;
                        //EDITAR ELEMENTO
                        db.Entry(funcionarios).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o funcionário com número de identificação (ID): " + funcionarios.id;

                        transation.Commit();
                        vetor[0] = "Funcionário editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o funcionário com número de identificação (ID): " + funcionarios.id + "\n \n " + ms.Message;
            }
        }

        ////: Editar ELEMENTO
        public async Task<string> UpdateState(Funcionarios funcionarios)
        {
            try
            {
                if (funcionarios.id == 0)
                {
                    return vetor[0] = "Selecione o serviço para pegar o número de idenfificação (ID).";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Funcionarios.AsNoTracking().FirstOrDefaultAsync(x => x.id == funcionarios.id);


                        if (take is null)
                            return vetor[0] = "O funcionário selecionado não foi encontrado";


                        take.estado = funcionarios.estado;
                        
                        //EDITAR ELEMENTO
                        db.Entry(take).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o estado do funcionário com número de identificação (ID): " + funcionarios.id;

                        transation.Commit();
                        vetor[0] = "Funcionário editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o funcionário com número de identificação (ID): " + funcionarios.id + "\n \n " + ms.Message;
            }
        }
    }
}