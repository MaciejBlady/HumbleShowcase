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
    
    public partial class Klienci
    {
        public Klienci()
        {
            this.Komunikaty = new HashSet<Komunikaty>();
        }
    
        public int IDKlienta { get; set; }
        public Nullable<System.DateTime> DataUrodzenia { get; set; }
        public string Haslo { get; set; }
        public string Login { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Nullable<int> NrDowodu { get; set; }
    
        public virtual KlienciLokujacy KlienciLokujacy { get; set; }
        public virtual KlienciPodejmujacy KlienciPodejmujacy { get; set; }
        public virtual ICollection<Komunikaty> Komunikaty { get; set; }
    }
}
