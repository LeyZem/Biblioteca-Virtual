namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GENERO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENERO()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_GENERO { get; set; }
        public string DESCRICAO { get; set; }
        public string ANDAR { get; set; }
        public string CORREDOR { get; set; }
        public string PRETELEIRA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
