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
    
    public partial class Wypozyczenia
    {
        public Wypozyczenia()
        {
            this.Ogledziny = new HashSet<Ogledziny>();
        }
    
        public int IDWypozyczenia { get; set; }
        public Nullable<int> IDDziecka { get; set; }
        public Nullable<int> IDKlientaPodejmujacego { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Komentarz { get; set; }
        public Nullable<int> Godziny { get; set; }
        public string Status { get; set; }
    
        public virtual Dzieci Dzieci { get; set; }
        public virtual KlienciPodejmujacy KlienciPodejmujacy { get; set; }
        public virtual ICollection<Ogledziny> Ogledziny { get; set; }
    }
}
