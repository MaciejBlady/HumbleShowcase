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
    
    public partial class Nianie
    {
        public Nianie()
        {
            this.Ogledziny = new HashSet<Ogledziny>();
        }
    
        public int IDNiani { get; set; }
        public Nullable<int> IDSuperniani { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    
        public virtual Supernianie Supernianie { get; set; }
        public virtual ICollection<Ogledziny> Ogledziny { get; set; }
    }
}
