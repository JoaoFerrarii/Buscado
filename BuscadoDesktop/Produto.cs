//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuscadoDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.Mercado_has_Produto = new HashSet<Mercado_has_Produto>();
        }
    
        public int idProduto { get; set; }
        public string Nome { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Imagem { get; set; }
        public Nullable<int> idEmpresa { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mercado_has_Produto> Mercado_has_Produto { get; set; }
    }
}
