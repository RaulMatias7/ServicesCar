using ServicesCars.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServicesCars.Operations
{
    public class OptLogin
    {
        ////: vetor[0] indica falso e retornara uma mensagem
        ////: vetor[1] indica verdadeiro

        public readonly string[] vetor = { null, null };
        public static List<Funcionarios> TakeUser { get; private set; }


        //: SELECIONAR ELEMENTOS
        public async Task<bool> GetUser(string usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuario))
                {
                    vetor[0] = "Insira o nome de usuário";
                    vetor[1] = null;
                    return false;
                }

                using (var db = new db_estacaoEntities())
                {
                    TakeUser = new List<Funcionarios>();

                    TakeUser = await (from x in db.Funcionarios
                                      where x.estado == "Habilitado" &&
                                          x.username == usuario
                                      select x).ToListAsync();

                    if (TakeUser.Count<=0 || TakeUser[0].username!=usuario)
                    {
                        vetor[1] = null;
                        vetor[0] = "Usuário não cadastrado...";
                        return false;
                    }

                    vetor[0] = null;
                    vetor[1] = "Good";
                    return true;
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //: SELECIONAR ELEMENTOS
        public bool GetSenha(string senha)
        {
            try
            {
                    if (TakeUser[0].senha != senha)
                    {
                        vetor[1] = null;
                        vetor[0] = "Senha de usuário incorreta...";
                        return false;
                    }


                    vetor[1] = "Good";
                    dsConfigure.csForms.id_user = TakeUser[0].id;
                    return true;
             }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}