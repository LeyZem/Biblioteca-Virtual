﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.View.CAluno {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CAluno.ICAluno")]
    public interface ICAluno {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Cadastrar", ReplyAction="http://tempuri.org/ICAluno/CadastrarResponse")]
        bool Cadastrar(Biblioteca.Model.ALUNO oAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Cadastrar", ReplyAction="http://tempuri.org/ICAluno/CadastrarResponse")]
        System.Threading.Tasks.Task<bool> CadastrarAsync(Biblioteca.Model.ALUNO oAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Alterar", ReplyAction="http://tempuri.org/ICAluno/AlterarResponse")]
        bool Alterar(Biblioteca.Model.ALUNO oAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Alterar", ReplyAction="http://tempuri.org/ICAluno/AlterarResponse")]
        System.Threading.Tasks.Task<bool> AlterarAsync(Biblioteca.Model.ALUNO oAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Selecionar", ReplyAction="http://tempuri.org/ICAluno/SelecionarResponse")]
        Biblioteca.Model.ALUNO Selecionar(int idAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/Selecionar", ReplyAction="http://tempuri.org/ICAluno/SelecionarResponse")]
        System.Threading.Tasks.Task<Biblioteca.Model.ALUNO> SelecionarAsync(int idAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/teste", ReplyAction="http://tempuri.org/ICAluno/testeResponse")]
        bool teste(Biblioteca.Model.ALUNO oAluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAluno/teste", ReplyAction="http://tempuri.org/ICAluno/testeResponse")]
        System.Threading.Tasks.Task<bool> testeAsync(Biblioteca.Model.ALUNO oAluno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICAlunoChannel : Biblioteca.View.CAluno.ICAluno, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CAlunoClient : System.ServiceModel.ClientBase<Biblioteca.View.CAluno.ICAluno>, Biblioteca.View.CAluno.ICAluno {
        
        public CAlunoClient() {
        }
        
        public CAlunoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CAlunoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CAlunoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CAlunoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Cadastrar(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.Cadastrar(oAluno);
        }
        
        public System.Threading.Tasks.Task<bool> CadastrarAsync(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.CadastrarAsync(oAluno);
        }
        
        public bool Alterar(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.Alterar(oAluno);
        }
        
        public System.Threading.Tasks.Task<bool> AlterarAsync(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.AlterarAsync(oAluno);
        }
        
        public Biblioteca.Model.ALUNO Selecionar(int idAluno) {
            return base.Channel.Selecionar(idAluno);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.Model.ALUNO> SelecionarAsync(int idAluno) {
            return base.Channel.SelecionarAsync(idAluno);
        }
        
        public bool teste(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.teste(oAluno);
        }
        
        public System.Threading.Tasks.Task<bool> testeAsync(Biblioteca.Model.ALUNO oAluno) {
            return base.Channel.testeAsync(oAluno);
        }
    }
}