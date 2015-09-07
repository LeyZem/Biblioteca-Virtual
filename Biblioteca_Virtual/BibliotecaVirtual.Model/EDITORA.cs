namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EDITORA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EDITORA()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_EDITORA { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string PAIS { get; set; }
        public string TEL_1 { get; set; }
        public string TEL_2 { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
