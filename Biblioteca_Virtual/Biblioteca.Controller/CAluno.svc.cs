using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAluno" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CAluno.svc or CAluno.svc.cs at the Solution Explorer and start debugging.
    public class CAluno : ICAluno
    {
        public bool Alterar(ALUNO oAluno)
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

        public bool Cadastrar(ALUNO oAluno)
        {
            if (AlunoMetod.Cadastrar(oAluno))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ALUNO Selecionar(int idAluno)
        {
            return AlunoMetod.Selecionar(idAluno);
        }
    }
}
