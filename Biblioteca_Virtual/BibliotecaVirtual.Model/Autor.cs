//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTOR()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_AUTOR { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public string BIOGRAFIA { get; set; }
        public string SITE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
