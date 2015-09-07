﻿    using System;
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
            var oDB = new BibliotecaVirtualEntities();

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
                    oDB.SaveChanges();
                    oDB.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
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
            }
            //Retorno TRUE para configuração de mensagem de sucesso
            return true;
        }

        /*public static bool Alterar(ALUNO )
        {
            var oDb = new BibliotecaVirtualEntities();


            return true;
        }*/

        public static bool Deletar(string IDAluno)
        {

            var oDB = new BibliotecaVirtualEntities();

            ALUNO oAluno = (from Seleciona in oDB.ALUNO where Seleciona.CPF == IDAluno select Seleciona).SingleOrDefault();

            oDB.ALUNO.Remove(oAluno);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }
    }
}
