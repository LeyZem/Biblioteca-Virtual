namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESERVA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVA()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_RESERVA { get; set; }
        public System.DateTime DATA_RES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
