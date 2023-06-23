using System;
using System.Collections.Generic;

#nullable disable

namespace Storage
{
    public partial class User
    {
        public User()
        {
            Profils = new HashSet<Profil>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public virtual ICollection<Profil> Profils { get; set; }
    }
}
