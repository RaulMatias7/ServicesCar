using System;
using System.Linq;
using System.Threading.Tasks;
using ServicesCars.Models;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
using System.Collections.Generic;

namespace ServicesCars.Operations
{
    public class optGrupos
    {

        public static List<Grupos> ListaOperacao { get; set; }
        //: vetor[0] indica falso e retornara uma mensagem
        //: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, "good" };

        //: SELECIONAR ELEMENTOS
        public async Task Get(DataGridView dgv)
        {
            try
            {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await (db.Grupos.AsNoTracking().Select(x => new { x.id, Grupo=x.grupo, criação = x.data_criacao, modificação = x.data_modificacao })).OrderByDescending(x => x.id).ToListAsync();

                    if (take.Count <= 0)
                        MessageBox.Show("A tabela não contém nenum registo.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public async Task<string> SearchById(int id)
        {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
        
                    var take = await (from x in db.Funcionarios where x.id == id select new { x.id, x.nome }).ToListAsync();
                //List<string> ls = new List<string> { take[0].id.ToString(), take[0].nome };

                //if (take is null)
                //    return "";

                return  take[0].nome ;
                }
        }

        //: SELECIONAR ELEMENTOS
        public async Task GetElementos(DataGridView dgv)
        {
            try
            {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await (db.FuncGroup.AsNoTracking().Select(x => new { x.id, x.Grupos.grupo, funcionário = x.Funcionarios.nome, x.Funcionarios.acesso })).OrderBy(x => x.grupo).ToListAsync();

                    //if (take is null)
                    //    MessageBox.Show("A tabela não contém nenum registo.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public async Task SearchElementos(DataGridView dgv,string search)
        {
            try { 
            using (db_estacaoEntities db = new db_estacaoEntities())
            {

                var take = await (from x in db.FuncGroup where x.Funcionarios.nome.Contains(search) || x.Grupos.grupo.Contains(search) orderby x.Grupos.grupo select new { x.id, x.Grupos.grupo, funcionário = x.Funcionarios.nome, x.Funcionarios.acesso }).ToListAsync();
              
                dgv.DataSource = take;
            }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        //: ADICIONAR ELEMENTO
        public string Add(Grupos grupos)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(grupos.grupo))
                {
                    return vetor[0] = "Insira o grupo do grupo a ser adicionados";
                }

                grupos.data_criacao = DateTime.Now;

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Grupos.Add(grupos);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível adicionar. \n  grupo: " + grupos.grupo + "\n \n ";

                        transation.Commit();
                        vetor[0] = "grupo adicionado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível adicionar. \n  grupo: " + grupos.grupo + "\n \n " + ms.Message;
            }
        }

        //: ELIMINAR ELEMENTO
        public async Task<string> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o grupo para pegar o número de idenfificação (ID).";
                }

                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await db.Grupos.FirstOrDefaultAsync(x => x.id == id);

                    //if (take is null)
                    //    return vetor[0] = "O grupo selecionado não foi encontrado";

                    db.Grupos.Remove(take);
                    if (db.SaveChanges() != 1)
                        return vetor[0] = "Não foi possível eliminar o grupo com número de identificação  (ID): " + id;

                    vetor[0] = "grupo eliminado com sucesso";
                    return vetor[1];
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível eliminar o grupo com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }

        //: ELIMINAR ELEMENTO
        public async Task<string> DeleteElemento(int id)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o grupo para pegar o número de idenfificação (ID).";
                }

                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await db.FuncGroup.FirstOrDefaultAsync(x => x.id == id);

                    db.FuncGroup.Remove(take);
                    if (db.SaveChanges() != 1)
                        return vetor[0] = "Não foi possível remover o funcionario do grupo com número de identificação  (ID): " + id;

                    vetor[0] = "Funcionário removido com sucesso";
                    return vetor[1];
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível remover o funcioário do grupo com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }


        ////: Editar ELEMENTO
        public async Task<string> Update(Grupos grupos)
        {
            try
            {
                if (grupos.id == 0)
                {
                    return vetor[0] = "Selecione o grupo para pegar o número de idenfificação (ID).";
                }
                if (string.IsNullOrWhiteSpace(grupos.grupo))
                {
                    return vetor[0] = "Insira o grupo do grupo para concluir a edição";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Grupos.AsNoTracking().FirstOrDefaultAsync(x => x.id == grupos.id);

                        //if (take is null)
                        //    return vetor[0] = "O grupo selecionado não foi encontrado";

                        grupos.data_criacao = take.data_criacao;
                        grupos.data_modificacao = DateTime.Now;

                        //EDITAR ELEMENTO
                        db.Entry(grupos).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi editar o grupo com número de identificação (ID): " + grupos.id;

                        transation.Commit();
                        vetor[0] = "grupo editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o grupo com número de identificação (ID): " + grupos.id + "\n \n " + ms.Message;
            }
        }

        //: PREENCHER A COMBOLBOX
        public static async Task FullCombol(ComboBox cbx)
        {
            try
            {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    ListaOperacao = new List<Grupos>();
                    ListaOperacao = await db.Grupos.ToListAsync();
                    ListaOperacao.OrderBy(x => x.grupo);
                    cbx.Items.Clear();

                    ListaOperacao.OrderBy(x => x.grupo);
                    foreach (var item in ListaOperacao)
                    {
                        cbx.Items.Add(item.grupo);
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: ADICIONAR Funcionario num Grupo
        public string IncluirGrupo(FuncGroup funcGroup)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.FuncGroup.Add(funcGroup);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível incluir este funcionário a um Grupo. ";

                        transation.Commit();
                        vetor[0] = "Funcionário incluído com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível incluir este funcionário ao Grupo." + ms.Message;
            }
        }
    }
}