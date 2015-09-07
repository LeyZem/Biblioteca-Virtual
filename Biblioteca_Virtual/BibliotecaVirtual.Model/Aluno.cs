namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALUNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALUNO()
        {
            this.Emprestimo = new HashSet<Emprestimo>();
        }
    
        public int ID_ALUNO { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public string CPF { get; set; }
        public string NASC { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string PAIS { get; set; }
        public string TEL_RES { get; set; }
        public string TEL_CEL { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
    }
}
