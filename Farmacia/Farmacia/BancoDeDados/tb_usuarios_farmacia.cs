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
    
    public partial class tb_usuarios_farmacia
    {
        public int id_usuario { get; set; }
        public Nullable<int> id_usuario_perfil { get; set; }
        public string tx_nome { get; set; }
        public string tx_cpf { get; set; }
        public string tx_login { get; set; }
        public string tx_senha { get; set; }
    
        public virtual tb_usuario_perfil_farmacia tb_usuario_perfil_farmacia { get; set; }
    }
}
