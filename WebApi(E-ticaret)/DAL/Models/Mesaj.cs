//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesaj
    {
        public int mesajID { get; set; }
        public Nullable<int> kullaniciID { get; set; }
        public string mesaj1 { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
    }
}