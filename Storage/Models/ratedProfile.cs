
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class ratedProfile
    {
        public Profil profil { get; set; }
        public int ocena { get; }

        public ratedProfile(Profil profil, int ocena)
        {
            this.profil = profil;
            this.ocena = ocena;
        }
    }
}
