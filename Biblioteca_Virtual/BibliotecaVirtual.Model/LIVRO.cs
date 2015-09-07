namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIVRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIVRO()
        {
            this.Emprestimo = new HashSet<Emprestimo>();
            this.AUTOR = new HashSet<AUTOR>();
            this.GENERO = new HashSet<GENERO>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public int ID_LIVRO { get; set; }
        public int ID_EDITORA { get; set; }
        public string TITULO { get; set; }
        public int VOLUME { get; set; }
        public System.DateTime DATA_PUBLIC { get; set; }
        public int QTD_EXMPLARES { get; set; }
        public int QTD_DISP_EMPR { get; set; }
        public string SUMARIO { get; set; }
    
        public virtual EDITORA EDITORA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTOR> AUTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERO> GENERO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}
