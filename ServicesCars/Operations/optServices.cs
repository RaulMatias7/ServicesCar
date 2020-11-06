using System;
using System.Linq;
using System.Threading.Tasks;
using ServicesCars.Models;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;

namespace ServicesCars.Operations
{
    public class optServices
    {

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
                    var take = await (db.Servicos.AsNoTracking().Select(x => new { x.id, x.nome, x.data_criacao, x.data_modificacao })).OrderByDescending(x => x.id).ToListAsync();

                    if (take.Count<=0)
                        MessageBox.Show("A tabela não contém nenum registo.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: ADICIONAR ELEMENTO
        public string Add(Servicos servicos)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(servicos.nome))
                {
                    return vetor[0] = "Insira o nome do serviço a ser adicionados";
                }

                servicos.data_criacao = DateTime.Now;

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Servicos.Add(servicos);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível adicionar. \n  Serviço: " + servicos.nome + "\n \n ";

                        transation.Commit();
                        vetor[0] = "Serviço adicionado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível adicionar. \n  Serviço: " + servicos.nome + "\n \n " + ms.Message;
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
                    var take = await db.Servicos.FirstOrDefaultAsync(x => x.id == id);

                    //if (take is null)
                    //    return vetor[0] = "O serviço selecionado não foi encontrado";

                    db.Servicos.Remove(take);
                    if (db.SaveChanges() != 1)
                        return vetor[0] = "Não foi possível eliminar o serviço com número de identificação  (ID): " + id;

                    vetor[0] = "Serviço eliminado com sucesso";
                    return vetor[1];
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível eliminar o serviço com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }

        ////: Editar ELEMENTO
        public async Task<string> Update(int id, Servicos servicos)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o serviço para pegar o número de idenfificação (ID).";
                }
                if (string.IsNullOrWhiteSpace(servicos.nome))
                {
                    return vetor[0] = "Insira o nome do serviço para concluir a edição";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Servicos.AsNoTracking().FirstOrDefaultAsync(x => x.id == id);

                        //if (take is null)
                        //    return vetor[0] = "O serviço selecionado não foi encontrado";

                        servicos.id = id;
                        servicos.data_criacao = take.data_criacao;
                        servicos.data_modificacao = DateTime.Now;

                        //EDITAR ELEMENTO
                        db.Entry(servicos).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi editar o serviço com número de identificação (ID): " + id;

                        transation.Commit();
                        vetor[0] = "Serviço editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o serviço com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }
    }
}