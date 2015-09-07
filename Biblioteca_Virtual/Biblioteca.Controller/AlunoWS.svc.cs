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
        public static void Cadastrar(ALUNO oAluno)
        {
            AlunoMetod.Cadastrar(oAluno);
        }
    }
}
