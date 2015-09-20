using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAutor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CAutor.svc or CAutor.svc.cs at the Solution Explorer and start debugging.
    public class CAutor : ICAutor
    {
        public bool Alterar(AUTOR oAutor)
        {
            if (AutorMetod.Alterar(oAutor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(AUTOR oAutor)
        {
            if (AutorMetod.Cadastrar(oAutor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AUTOR Selecionar(int idAutor)
        {
            return AutorMetod.Selecionar(idAutor);
        }
    }
}
