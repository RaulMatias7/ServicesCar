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
    public class OptCoorporacao
    {
        ////: vetor[0] indica falso e retornara uma mensagem
        ////: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, "good" };
        public List<Empresas> TakeEmpresas { get; private set; }
        public List<vwFacturasEmpresas> TakeFacturas { get; private set; }
        //public List<vwCaixa> TakeListCaixa { get; private set; }
        //: SELECIONAR ELEMENTOS
        public async Task Get(DataGridView dgv)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {

                    var TakeList = await (from a in db.Empresas
                                          orderby a.id descending
                                          select new
                                          {
                                              a.id,
                                              a.nome,
                                              a.NIF,
                                              localização = a.localizacao,
                                              descrição = a.descricao,
                                              a.contacto,
                                              a.email,
                                              a.banco,
                                              conta = a.num_conta,
                                              a.IBAN,
                                              criação = a.data_criacao,
                                              modificação = a.data_modificacao
                                          }).ToListAsync();

                    dgv.DataSource = TakeList;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public async void GetBySearch(DataGridView dgv,string search)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {

                    var TakeList = await (from a in db.Empresas
                                          where a.nome.Contains(search) || a.localizacao.Contains(search) || a.NIF.Contains(search) || a.banco.Contains(search) || a.descricao.Contains(search) || a.IBAN.Contains(search) || a.num_conta.Contains(search) || a.contacto.Contains(search) || a.email.Contains(search)
                                          orderby a.id descending
                                          select new
                                          {
                                              a.id,
                                              a.nome,
                                              a.NIF,
                                              localização = a.localizacao,
                                              descrição = a.descricao,
                                              a.contacto,
                                              a.email,
                                              a.banco,
                                              conta = a.num_conta,
                                              a.IBAN,
                                              criação = a.data_criacao,
                                              modificação = a.data_modificacao
                                          }).ToListAsync();

                    dgv.DataSource = TakeList;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public async Task GetFacturas(DataGridView dgv, int ano = 0, int mes = 0)
        {
            try
            {
                using (var db = new db_estacaoEntities())
                {
                    TakeFacturas = new List<vwFacturasEmpresas>();

                    if (mes == 0)
                    {
                        TakeFacturas = await (from a in db.vwFacturasEmpresas
                                              where a.data_criacao.Value.Year.Equals(ano)
                                      orderby a.id descending, a.data_criacao descending
                                      select a).ToListAsync();
                    }
                    else if (mes != 0)
                    {
                        TakeFacturas = await (from a in db.vwFacturasEmpresas where a.data_criacao.Value.Year.Equals(ano) && a.data_criacao.Value.Month.Equals(mes) orderby a.id descending, a.data_criacao descending
                                      select  a ).ToListAsync();
                    }
                    else
                    {
                        csDrag.PrintMessenge("Condição inválida", false);
                    }

                    dgv.DataSource = TakeFacturas;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: SELECIONAR ELEMENTOS
        public void GetBySearchFacturas(DataGridView dgv, string search)
        {
            try
            {
                dgv.DataSource = (from a in TakeFacturas
                                  where a.id.ToString().ToLower().Contains(search) || a.idEmpresa.ToString().ToLower().Contains(search) || a.numEncomenda.ToString().ToLower().Contains(search) || a.tipo.ToLower().Contains(search) || a.nome.ToLower().Contains(search) 
                                  orderby a.id descending, a.data_criacao descending
                                  select a).ToList();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: ADICIONAR ELEMENTO
        public string AddEmpresa(Empresas empresas)
        {
            try
            {

                empresas.data_criacao = DateTime.Now;

                if (string.IsNullOrWhiteSpace(empresas.nome))
                {
                    return vetor[0] = "Insira o nome da empresa a ser adicionada";
                }
                if (string.IsNullOrWhiteSpace(empresas.localizacao))
                {
                    return vetor[0] = "Insira a localização da empresa a ser adicionada";
                }
                if (string.IsNullOrWhiteSpace(empresas.num_conta))
                {
                    return vetor[0] = "Insira o número da conta da empresa a ser adicionada";
                }
                if (string.IsNullOrWhiteSpace(empresas.NIF))
                {
                    return vetor[0] = "Insira o NIF da empresa a ser adicionada";
                }
                if (string.IsNullOrWhiteSpace(empresas.IBAN))
                {
                    return vetor[0] = "Insira o IBAN da empresa a ser adicionada";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.Empresas.Add(empresas);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível registar esta empresa";

                        transation.Commit();
                        vetor[0] = "Empresa registada com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível registar esta empresa \n Erro:" + ms.Message;
            }
        }

        //: ADICIONAR ELEMENTO
        public string AddFacturaEmpresa(FaturasEmpresa fatura)
        {
            try
            {

                fatura.data_criacao = DateTime.Now;
                fatura.Total = (fatura.precoKilo * fatura.kilos);
                if (fatura.idEmpresa<=0)
                {
                    return vetor[0] = "Insira o número da empresa";
                }
                if (fatura.numEncomenda <= 0)
                {
                    return vetor[0] = "Insira o número da encomenda";
                }
                if (fatura.precoKilo <= 0)
                {
                    return vetor[0] = "Insira o preço de cada kilo";
                }
                if (string.IsNullOrWhiteSpace(fatura.tipo))
                {
                    return vetor[0] = "Insira o tipo de produto";
                }

                
                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        db.FaturasEmpresa.Add(fatura);
                        if (db.SaveChanges() != 1) return vetor[0] = "Não foi possível concluir esta operação. Tente mais tarde.";

                        transation.Commit();
                        vetor[0] = "Operação concluida com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível concluir esta operação. Tente mais tarde. \n Erro:" + ms.Message;
            }
        }


        ////: Editar ELEMENTO
        public async Task<string> Update(Empresas empresas)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empresas.nome))
                {
                    return vetor[0] = "Insira o nome da empresa";
                }
                if (string.IsNullOrWhiteSpace(empresas.localizacao))
                {
                    return vetor[0] = "Insira a localização da empresa";
                }
                if (string.IsNullOrWhiteSpace(empresas.num_conta))
                {
                    return vetor[0] = "Insira o número da conta da empresa";
                }
                if (string.IsNullOrWhiteSpace(empresas.NIF))
                {
                    return vetor[0] = "Insira o NIF da empresa";
                }
                if (string.IsNullOrWhiteSpace(empresas.IBAN))
                {
                    return vetor[0] = "Insira o IBAN da empresa";
                }

                using (var db = new db_estacaoEntities())
                {
                    using (var transation = db.Database.BeginTransaction())
                    {
                        //: selecionar o elemto com id especificado
                        var take = await db.Empresas.AsNoTracking().FirstOrDefaultAsync(x => x.id == empresas.id);


                        empresas.data_criacao = take.data_criacao;
                        empresas.data_modificacao = DateTime.Now;
                        
                        //EDITAR ELEMENTO
                        db.Entry(empresas).State = EntityState.Modified;

                        if (db.SaveChanges() != 1)
                            return vetor[0] = "Não foi possível editar o registo com número de identificação (ID): " + empresas.id;

                        transation.Commit();
                        vetor[0] = "Registo actualizado com sucesso";
                        return vetor[1];
                    }
                }
            }
            catch (Exception ms)
            {
                return vetor[0] = "Não foi possível editar o registo com número de identificação (ID): " + empresas.id + "\n \n " + ms.Message;
            }
        }

        //: ELIMINAR ELEMENTO
        public async Task<string> Delete(int id)
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
                        var take = await db.Empresas.FirstOrDefaultAsync(x => x.id == id);

                        db.Empresas.Remove(take);
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

        //: ELIMINAR ELEMENTO
        public void GetListEmpresaById(int id)
        {
            try
            {

                TakeEmpresas = new List<Empresas>();
                using (db_estacaoEntities db = new db_estacaoEntities())
                {
                    TakeEmpresas = (from x in db.Empresas where x.id==id select x).ToList();
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show("erro: "+ms.Message);
            }
        }

    }
}