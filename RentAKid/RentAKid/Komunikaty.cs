//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentAKid
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komunikaty
    {
        public int IDKomunikatu { get; set; }
        public int IDKlienta { get; set; }
        public int IDSuperniani { get; set; }
        public string Tresc { get; set; }
        public System.DateTime Data { get; set; }
        public string Status { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        public virtual Supernianie Supernianie { get; set; }
    }
}
