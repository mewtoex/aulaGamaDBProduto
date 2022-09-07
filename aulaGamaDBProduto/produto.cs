//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aulaGamaDBProduto
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produto()
        {
            this.alimentoes = new HashSet<alimento>();
            this.eletrodomesticoes = new HashSet<eletrodomestico>();
        }
    
        public int IdProduto { get; set; }
        public string nome { get; set; }
        public string unid { get; set; }
        public string statusProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Armazenagem { get; set; }
        public Nullable<decimal> PrecoCompra { get; set; }
        public Nullable<decimal> PrecoLucro { get; set; }
        public Nullable<decimal> PrecoVenda { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alimento> alimentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eletrodomestico> eletrodomesticoes { get; set; }
    }
}