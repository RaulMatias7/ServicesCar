using System;
using System.Linq;
using System.Threading.Tasks;
using ServicesCars.Models;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;

namespace ServicesCars.Operations
{
    public class optPromocoes
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
                    var take = await (db.Promocoes.AsNoTracking().Select(x => x ).OrderByDescending(x => x.total).OrderByDescending(x=> x.contagem)).Where(x=> x.total>=10).ToListAsync();

                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

        //: SELECIONAR ELEMENTOS
        public async Task GetBySearch(DataGridView dgv, string search)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    var take = await (from x in db.Promocoes
                                      where x.matricula.Contains(search) || x.contagem.ToString().Contains(search) || x.total.ToString().Contains(search) && x.total>=10
                                      orderby x.total descending, x.contagem descending 
                                      select x).ToListAsync();

                    dgv.DataSource = take;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ////: Editar ELEMENTO
        public async Task<string> Reiniciar(int id)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o registo para pegar o número de idenfificação (ID).";
                }
               

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Promocoes.AsNoTracking().FirstOrDefaultAsync(x => x.id == id);

                        //if (take is Nullable)
                        //    return vetor[0] = "O registo selecionado não foi encontrado";

                        take.contagem = 0;

                        //EDITAR ELEMENTO
                        db.Entry(take).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possivel reiniciar o registo com número de identificação (ID): " + id;

                        transation.Commit();
                        vetor[0] = "Reiniciado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possivel reiniciar o registo  comnúmero de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }
    }
}