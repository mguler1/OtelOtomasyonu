//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelOtomasyonu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefon
    {
        public int TelefonId { get; set; }
        public string Aciklama { get; set; }
        public string Telefon1 { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual Durum Durum1 { get; set; }
    }
}
