namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emprestimo
    {
        public int ID_EMPRESTIMO { get; set; }
        public int ID_ALUNO { get; set; }
        public int ID_LIVRO { get; set; }
        public int ID_EDITORA { get; set; }
        public System.DateTime DATA_EMP { get; set; }
        public System.DateTime DATA_DEVOL { get; set; }
    
        public virtual ALUNO ALUNO { get; set; }
        public virtual LIVRO LIVRO { get; set; }
    }
}
