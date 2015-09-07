    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class AlunoMetod
    {
        public static bool Cadastrar(ALUNO oAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            oDB.ALUNO.Add(oAluno);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        } 
    }
}
