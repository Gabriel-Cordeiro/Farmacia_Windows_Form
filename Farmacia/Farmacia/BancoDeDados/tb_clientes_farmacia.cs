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
    
    public partial class tb_clientes_farmacia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_clientes_farmacia()
        {
            this.tb_produtos_vendidos_farmacia = new HashSet<tb_produtos_vendidos_farmacia>();
        }
    
        public int id_cliente { get; set; }
        public string tx_nome { get; set; }
        public Nullable<decimal> in_cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_produtos_vendidos_farmacia> tb_produtos_vendidos_farmacia { get; set; }
    }
}