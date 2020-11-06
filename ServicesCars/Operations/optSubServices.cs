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
    public class optSubServices
    {
        public List<Servicos> ListaServico { get; set; }
        //: vetor[0] indica falso e retornara uma mensagem
        //: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, "good" };

        //: SELECIONAR ELEMENTOS
        public async Task Get(DataGridView dgv)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    var take = await db.SubServicos.AsNoTracking().Include(x => x.Servicos).Select(x => new
                    {
                        Id = x.id,
                        serviço = x.Servicos.nome,
                        x.modelo,
                        preço=x.preco,
                        criação = x.data_criacao,
                        modificação = x.data_modificacao
                    }).OrderByDescending(x => x.criação).ToListAsync();

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
                    var take = await (from x in db.SubServicos
                                      where x.modelo.Contains(search) || x.Servicos.nome.Contains(search)
                                      orderby x.data_criacao
                                      select new
                                      {
                                          Id = x.id,
                                          serviço = x.Servicos.nome,
                                          x.modelo,
                                          preço = x.preco,
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

        //: PREENCHER A COMBOLBOX
        public async Task FullCombol(ComboBox cbx)
        {
            try
            {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    ListaServico = new List<Servicos>();
                    ListaServico = await db.Servicos.ToListAsync();
                    ListaServico.OrderBy(x => x.nome);
                    cbx.Items.Clear();

                    ListaServico.OrderBy(x => x.nome);
                    foreach (var item in ListaServico)
                    {
                        cbx.Items.Add(item.nome);
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //: ADICIONAR ELEMENTO
        public string Add(SubServicos subservicos)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(subservicos.modelo))
                {
                    return vetor[0] = "Insira o modelo do serviço a ser adicionados";
                }

                subservicos.data_criacao = DateTime.Now;

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.SubServicos.Add(subservicos);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível adicionar este Serviço";

                        transation.Commit();
                        vetor[0] = "Serviço adicionado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível adicionar este Serviço \n Erro:" + ms.Message;
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
                    var take = await db.SubServicos.FirstOrDefaultAsync(x => x.id == id);

                    //if (take is null)
                    //    return vetor[0] = "O serviço selecionado não foi encontrado";

                    db.SubServicos.Remove(take);
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
        public async Task<string> Update(SubServicos subServicos)
        {
            try
            {
                if (subServicos.id == 0)
                {
                    return vetor[0] = "Selecione o serviço para pegar o número de idenfificação (ID).";
                }
                if (string.IsNullOrWhiteSpace(subServicos.modelo))
                {
                    return vetor[0] = "Insira o modelo do serviço para concluir a edição";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.SubServicos.AsNoTracking().FirstOrDefaultAsync(x => x.id == subServicos.id);

                        //if (take is null)
                        //    return vetor[0] = "O serviço selecionado não foi encontrado";

                        //subServicos.id = id;
                        subServicos.data_criacao = take.data_criacao;
                        subServicos.data_modificacao = DateTime.Now;

                        //EDITAR ELEMENTO
                        db.Entry(subServicos).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o serviço com número de identificação (ID): " + subServicos.id;

                        transation.Commit();
                        vetor[0] = "Serviço editado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o serviço com número de identificação (ID): " + subServicos.id + "\n \n " + ms.Message;
            }
        }
    }
}