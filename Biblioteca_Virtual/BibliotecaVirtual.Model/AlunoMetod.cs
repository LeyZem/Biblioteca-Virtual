using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Biblioteca.Model
{
    public class AlunoMetod
    {
        public static bool Cadastrar(ALUNO pAluno)
        {
            //var oDB = new BibliotecaVirtualEntities();
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

              

                //String de Seleção do usuário
                var ConsultaUsuario = (from cu in oDB.ALUNO
                                       where cu.CPF == pAluno.CPF
                                       select cu).SingleOrDefault();

                //Se a consulta retorna NULA ele cadastra o usuário    
                if (ConsultaUsuario == null)
                {
                    try
                    {
                        oDB.ALUNO.Add(pAluno);
                        //oDB.Entry(pAluno).State = System.Data.Entity.EntityState.Added;
                        oDB.SaveChanges();
                        oDB.Dispose();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return true;
                }
                //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
                else
                {
                    return false;
                }
            }
         }

        public static bool Alterar(ALUNO pAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.CPF == pAluno.CPF
                                   select cu).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaUsuario != null)
            {
                try
                {
                    ConsultaUsuario.NOME = pAluno.NOME;
                    ConsultaUsuario.SOBRENOME = pAluno.SOBRENOME;
                    ConsultaUsuario.NASC = pAluno.NASC;
                    ConsultaUsuario.CPF = pAluno.CPF;
                    ConsultaUsuario.ENDERECO = pAluno.ENDERECO;
                    ConsultaUsuario.BAIRRO = pAluno.BAIRRO;
                    ConsultaUsuario.CIDADE = pAluno.CIDADE;
                    ConsultaUsuario.UF = pAluno.UF;
                    ConsultaUsuario.PAIS = pAluno.PAIS;
                    ConsultaUsuario.CEP = pAluno.CEP;
                    ConsultaUsuario.TEL_RES = pAluno.TEL_RES;
                    ConsultaUsuario.TEL_CEL = pAluno.TEL_CEL;
                    ConsultaUsuario.EMAIL = pAluno.EMAIL;

                    oDB.SaveChanges();
                    oDB.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Deletar(string IDAluno)
        {

            var oDB = new BibliotecaVirtualEntities();

            ALUNO oAluno = (from Seleciona in oDB.ALUNO where Seleciona.CPF == IDAluno select Seleciona).SingleOrDefault();

            oDB.ALUNO.Remove(oAluno);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }

        public static ALUNO Selecionar(int IDAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.ID_ALUNO == IDAluno
                                   select cu).SingleOrDefault();

            if (ConsultaUsuario == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                ALUNO oAluno = new ALUNO();

                oAluno.NOME = ConsultaUsuario.NOME;
                oAluno.SOBRENOME = ConsultaUsuario.SOBRENOME;
                oAluno.NASC = ConsultaUsuario.NASC;
                oAluno.CPF = ConsultaUsuario.CPF;
                oAluno.ENDERECO = ConsultaUsuario.ENDERECO;
                oAluno.BAIRRO = ConsultaUsuario.BAIRRO;
                oAluno.CIDADE = ConsultaUsuario.CIDADE;
                oAluno.UF = ConsultaUsuario.UF;
                oAluno.PAIS = ConsultaUsuario.PAIS;
                oAluno.CEP = ConsultaUsuario.CEP;
                oAluno.TEL_RES = ConsultaUsuario.TEL_RES;
                oAluno.TEL_CEL = ConsultaUsuario.TEL_CEL;
                oAluno.EMAIL = ConsultaUsuario.EMAIL;

                return oAluno;
            }
        }




        public static ALUNO SelecionarCPF(string CPFAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.CPF == CPFAluno
                                   select cu).SingleOrDefault();

            if (ConsultaUsuario == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                ALUNO oAluno = new ALUNO();

                oAluno.NOME = ConsultaUsuario.NOME;
                oAluno.SOBRENOME = ConsultaUsuario.SOBRENOME;
                oAluno.NASC = ConsultaUsuario.NASC;
                oAluno.CPF = ConsultaUsuario.CPF;
                oAluno.ENDERECO = ConsultaUsuario.ENDERECO;
                oAluno.BAIRRO = ConsultaUsuario.BAIRRO;
                oAluno.CIDADE = ConsultaUsuario.CIDADE;
                oAluno.UF = ConsultaUsuario.UF;
                oAluno.PAIS = ConsultaUsuario.PAIS;
                oAluno.CEP = ConsultaUsuario.CEP;
                oAluno.TEL_RES = ConsultaUsuario.TEL_RES;
                oAluno.TEL_CEL = ConsultaUsuario.TEL_CEL;
                oAluno.EMAIL = ConsultaUsuario.EMAIL;

                return oAluno;
            }
        }
    }
}
