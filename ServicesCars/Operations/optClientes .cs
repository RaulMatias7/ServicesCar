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
                    var take = await db.Clientes.AsNoTracking().Select(x => new { 
                        x.id,
                        cliente=x.nome,
                        x.sexo,
                        x.contacto,
                        x.email,
                        data=x.dataN,
                        x.NIF,
                        criação = x.data_criacao
                    }).OrderByDescending(x => x.id).ToListAsync();

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
                    var take = await (from x in db.Clientes
                                      where x.nome.Contains(search) || x.sexo.Contains(search) || x.email.Contains(search) || x.contacto.Contains(search) || x.NIF.Contains(search)
                                      orderby x.id descending
                                      select new
                                      {
                                          x.id,
                                          cliente = x.nome,
                                          x.sexo,
                                          x.contacto,
                                          x.email,
                                          data = x.dataN,
                                          x.NIF,
                                          criação = x.data_criacao
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
        public string Add(Clientes clientes)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(clientes.nome))
                {
                    return vetor[0] = "Insira o nome do cliente a ser adicionado";
                }

                clientes.data_criacao = DateTime.Now;
                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Clientes.Add(clientes);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível adicionar este cliente";

                        transation.Commit();
                        vetor[0] = "cliente adicionado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível adicionar este cliente \n Erro:" + ms.Message;
            }
        }

        ////: Editar ELEMENTO
        public async Task<string> Update(Clientes clientes)
        {
            try
            {
                if (clientes.id == 0)
                {
                    return vetor[0] = "Selecione o cliente para pegar o número de idenfificação (ID).";
                }
                if (string.IsNullOrWhiteSpace(clientes.nome))
                {
                    return vetor[0] = "Insira o nome do cliente a ser editado";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        //var take = await db.Clientes.AsNoTracking().FirstOrDefaultAsync(x => x.id == clientes.id);
                        var take = (from x in db.Clientes where x.id==clientes.id select x).ToList();

                        if (take.Count<=0)
                            return vetor[0] = "O funcionário selecionado não foi encontrado";

                        //subServicos.id = id;
                        clientes.data_criacao = take.FirstOrDefault().data_criacao;
                        //EDITAR ELEMENTO
                        db.Entry(clientes).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o cliente com número de identificação (ID): " + clientes.id;

                        transation.Commit();
                        vetor[0] = "cliente editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o cliente com número de identificação (ID): " + clientes.id + "\n \n " + ms.Message;
            }
        }
  
        //: ELIMINAR ELEMENTO
        public async Task<string> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o serviço para pegar o número de idenfificação (ID).";
                }

                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await db.Clientes.FirstOrDefaultAsync(x => x.id == id);
                     
                    db.Clientes.Remove(take);
                    if (db.SaveChanges() != 1)
                        return vetor[0] = "Não foi possível eliminar o cliente com número de identificação  (ID): " + id;

                    vetor[0] = "cliente eliminado com sucesso";
                    return vetor[1];
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível eliminar o cliente com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }
    }
}