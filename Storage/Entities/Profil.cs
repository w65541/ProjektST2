using System;
using System.Collections.Generic;

#nullable disable

namespace Storage
{
    public partial class Profil
    {
        public Profil()
        {
            RejectionRejectedNavigations = new HashSet<Rejection>();
            RejectionRejecteeNavigations = new HashSet<Rejection>();
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public sbyte Plec { get; set; }
        public byte[] Photo { get; set; }
        public int Atrybut1 { get; set; }
        public int Atrybut2 { get; set; }
        public int Atrybut3 { get; set; }
        public int Atrybut4 { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Rejection> RejectionRejectedNavigations { get; set; }
        public virtual ICollection<Rejection> RejectionRejecteeNavigations { get; set; }
    }
}
