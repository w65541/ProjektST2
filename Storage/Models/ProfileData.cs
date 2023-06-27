using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Klasa przechowująca dane do modelu strony Profile
 */
namespace Storage.Models
{
   public class ProfileData
    {
       public Profil Profil { get; set; }
       public int IdUser { get; set; }
        public int Id { get; set; }
        public ProfileData(Profil profil, int id,int idUser)
        {
            this.Profil = profil;
            this.Id = id;
            this.IdUser = idUser;
        }
    }
}
