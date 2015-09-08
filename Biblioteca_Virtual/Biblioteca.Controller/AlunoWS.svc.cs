using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    public class AlunoWS
    {
        public static bool Cadastrar(ALUNO oAluno)
        {
            if(AlunoMetod.Cadastrar(oAluno))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Alterar(ALUNO oAluno)
        {
            if (AlunoMetod.Alterar(oAluno))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
