//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Farmacia.BancoDeDados
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_produtos_farmacia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_produtos_farmacia()
        {
            this.tb_produtos_vendidos_farmacia = new HashSet<tb_produtos_vendidos_farmacia>();
        }
    
        public int id_produto { get; set; }
        public string tx_nome_produto { get; set; }
        public Nullable<bool> fl_cronico { get; set; }
        public Nullable<bool> fl_alergenicos { get; set; }
        public byte[] img_produto { get; set; }
        public Nullable<decimal> valor_produto { get; set; }
        public Nullable<int> porcentagem_desconto_recorrente { get; set; }
        public Nullable<int> in_quantidade { get; set; }
        public Nullable<int> porcentagem_desconto_cronico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_produtos_vendidos_farmacia> tb_produtos_vendidos_farmacia { get; set; }
    }
}
