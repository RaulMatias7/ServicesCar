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
    public class optAtendimentos
    {
        ////: vetor[0] indica falso e retornara uma mensagem
        ////: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, "good" };
        public List<vwAtendimentos> TakeList { get; private set; }
        public List<vwCaixa> TakeListCaixa { get; private set; }
        //: SELECIONAR ELEMENTOS
        public async Task Get(DataGridView dgv, int ano = 0, int mes = 0, int dia = 0, string dados = "Hoje")
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    TakeList = new List<vwAtendimentos>();

                    if (dados == "Hoje")
                    {
                        TakeList = await (from a in db.vwAtendimentos where a.data.Year.Equals(ano) && a.data.Month.Equals(mes) && a.data.Day.Equals(dia) orderby a.id descending, a.data descending select a).ToListAsync();
                    }
                    else if (dados == "Geral")
                    {
                        if (mes == 0 && dia !=0)
                        {
                            TakeList = await (from a in db.vwAtendimentos
                                              where a.data.Year.Equals(ano) && a.data.Day.Equals(dia)
                                              orderby a.id descending, a.data descending
                                              select a).ToListAsync();
                        }
                        else if (mes!=0 && dia != 0)
                        {
                            TakeList = await (from a in db.vwAtendimentos where a.data.Year.Equals(ano) && a.data.Month.Equals(mes) && a.data.Day.Equals(dia) orderby a.id descending, a.data descending select a).ToListAsync();
                        }
                        else if (mes != 0 && dia == 0)
                        {
                            TakeList = await (from a in db.vwAtendimentos where a.data.Year.Equals(ano) && a.data.Month.Equals(mes) orderby a.id descending, a.data descending select a).ToListAsync();
                        }
                        else if (mes == 0 && dia == 0)
                        {
                            TakeList = await (from a in db.vwAtendimentos where a.data.Year.Equals(ano) orderby a.id descending, a.data descending select a).ToListAsync();
                        }
                        else{
                            csDrag.PrintMessenge("Condição inválida", false);
                        }
                    }

                    dgv.DataSource = TakeList;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public void GetBySearch(DataGridView dgv,string search)
        {
            try
            {
                dgv.DataSource = (from a in TakeList
                                  where a.cliente.ToLower().Contains(search)
                                  || a.estado.ToLower().Contains(search)
                                  || a.funcionário.ToLower().Contains(search)
                                  || a.grupo.ToLower().Contains(search)
                                  || a.marca.ToLower().Contains(search)
                                  || a.modelo.ToLower().Contains(search)
                                  || a.pagamento.ToLower().Contains(search)
                                  || a.serviço.ToLower().Contains(search)
                                  orderby a.id descending, a.data descending
                                  select a).ToList();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public int GetLastPagamentos()
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    return db.Pagamentos.OrderByDescending(x => x.id).FirstOrDefault().id;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

        //: ADICIONAR ELEMENTO
        public string AddPagamento(Pagamentos pagamentos)
        {
            try
            {

                pagamentos.dataEntrada = DateTime.Now;
                pagamentos.horaEntrada = TimeSpan.Parse(DateTime.Now.ToLongTimeString());
                pagamentos.total = (pagamentos.montante + pagamentos.multicaixa);
                pagamentos.estado = "activo";

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Pagamentos.Add(pagamentos);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível efectuar o pagamanto";

                        transation.Commit();
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível efectuar o pagamento \n Erro:" + ms.Message;
            }
        }

        //: ADICIONAR ELEMENTO
        public string Add(Atendimento atendimento)
        {
            try
            {

                if (atendimento.idSubServico == 0)
                {
                    return vetor[0] = "Selecione o tipo de serviço";
                }
                if (atendimento.idGrupo == 0)
                {
                    return vetor[0] = "Selecione o grupo";
                }
                if (string.IsNullOrWhiteSpace(atendimento.matricula))
                {
                    return vetor[0] = "Insira o número da matrícula da viatura";
                }


                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Atendimento.Add(atendimento);

                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível registar este atendimento";

                        transation.Commit();
                        vetor[0] = "Atendimento efectuado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível registar este atendimento \n Erro:" + ms.Message;
            }
        }

        ////: Editar ELEMENTO
        public async Task<string> UpdateState(Pagamentos pagamentos)
        {
            try
            {
                if (pagamentos.id == 0)
                {
                    return vetor[0] = "Selecione o registo para pegar o número de idenfificação (ID).";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Pagamentos.AsNoTracking().FirstOrDefaultAsync(x => x.id == pagamentos.id);


                        //if (take is null)
                        //    return vetor[0] = "O Registo selecionado não foi encontrado";


                        take.estado = pagamentos.estado;

                        //EDITAR ELEMENTO
                        db.Entry(take).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o estado do registo com número de identificação (ID): " + pagamentos.id;

                        transation.Commit();
                        vetor[0] = "estado actualizado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o registo com número de identificação (ID): " + pagamentos.id + "\n \n " + ms.Message;
            }
        }

        //: ELIMINAR ELEMENTO
        public async Task<string> DeletePagamento(int id)
        {
            try
            {
                if (id == 0)
                {
                    return vetor[0] = "Selecione o número de idenfificação (ID).";
                }

                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        var take = await db.Pagamentos.FirstOrDefaultAsync(x => x.id == id);

                        //if (take is null)
                        //    return vetor[0] = "O registo selecionado não foi encontrado";

                        //db.spUpdateCaixa(id);

                        db.Database.ExecuteSqlCommand("exec spUpdateCaixa " + id + "");

                        db.Pagamentos.Remove(take);
                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível eliminar o registo com número de identificação  (ID): " + id;
                        transation.Commit();
                        vetor[0] = "Registo eliminado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível eliminar o registo com número de identificação (ID): " + id + "\n \n " + ms.Message;
            }
        }

        ////: SELECIONAR CAIXA
        public async Task<int[]> StateCaixa(int idFuncionario)
        {
            int[] vetor = new int[4];

            try
            {
                using (var db = new db_estacaoEntities())
                {
                        var take = await (from x in db.Pagamentos where x.dataEntrada.Year.Equals(DateTime.Now.Year) && x.dataEntrada.Month.Equals(DateTime.Now.Month) && x.dataEntrada.Day.Equals(DateTime.Now.Day) && x.estado=="activo" && x.idFuncionario==idFuncionario select new { x.multicaixa, x.montante }).ToListAsync();
                    
                    vetor[0] = (int)take.Sum(x => x.montante).Value;
                    vetor[1] = (int)take.Sum(x => x.multicaixa).Value;
                    vetor[2] = (int)take.Sum(x => (x.multicaixa+x.montante)).Value;
                    vetor[3] = take.Count;

                }
            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message, false);
            }
            return vetor;
        }


        ////:=========================== ÁREA DO CAIXA 

        //: SELECIONAR ELEMENTOS
        public async Task GetCaixa(DataGridView dgv, int ano = 0, int mes = 0)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    TakeListCaixa = new List<vwCaixa>();

                        if (mes == 0)
                        {
                            TakeListCaixa = await (from a in db.vwCaixa
                                                   where a.data.Year.Equals(ano)
                                              orderby a.id descending, a.data descending
                                              select a).ToListAsync();
                        }
                        else if (mes != 0)
                        {
                            TakeListCaixa = await (from a in db.vwCaixa where a.data.Year.Equals(ano) && a.data.Month.Equals(mes) orderby a.id descending, a.data descending select a).ToListAsync();
                        }
                        else
                        {
                            csDrag.PrintMessenge("Condição inválida", false);
                        }
       
                    dgv.DataSource = TakeListCaixa;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public void GetBySearchCaixa(DataGridView dgv, string search)
        {
            try
            {
                dgv.DataSource = (from a in TakeListCaixa
                                  where a.funcionário.ToLower().Contains(search) || a.referência.ToLower().Contains      (search)
                                  orderby a.id descending, a.data descending
                                  select a).ToList();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ////:============================== AREA DE PROMOCOES
        ///

        //: Pesquisar Matricula
        public async Task<int> GetMatricula(string matricula)
        {
            try
            {
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    var take = await (from x in db.Promocoes where  x.matricula == matricula select new { x.contagem, x.total } ).ToListAsync();
                    return (int)take.Sum(x => x.contagem).Value;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}