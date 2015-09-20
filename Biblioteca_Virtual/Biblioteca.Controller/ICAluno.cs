using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICAluno" in both code and config file together.
    [ServiceContract]
    public interface ICAluno
    {
        [OperationContract]
        bool Cadastrar(ALUNO oAluno);

        [OperationContract]
        bool Alterar(ALUNO oAluno);

        [OperationContract]
        ALUNO Selecionar(int idAluno);

        [OperationContract]
        ALUNO SelecionarCPF(string CPFAluno);
    }
}
