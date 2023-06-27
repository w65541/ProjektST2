using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Storage.Models;

namespace Storage.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class DatingSiteController : ControllerBase
    {

        private readonly datingsiteContext _context;
        private readonly ILogger<DatingSiteController> _logger;

        public DatingSiteController(ILogger<DatingSiteController> logger, datingsiteContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet("LoginUser")]
        public int GetId(string login,string password)
        {
            Console.WriteLine(login + " " + password);
            var temp = _context.Users.Where(x => x.Login.Equals(login) && x.Haslo.Equals(password)).ToList();
            if (temp.Count > 0)
            {
            int id=temp.First().Id;
                Console.WriteLine(id);
                return id;
            }
               
            return 0;
        }

        [HttpGet("ProfileGet")]
        public Profil GetProfil(int id)
        {
            var temp = _context.Profils.Where(x => x.IdUser == id).ToList();
            if (temp.Count > 0) return temp.First();
            return null;
        }



        [HttpGet("ProfileDelete")]
        public int DeleteProfile(int id)
        {
            var temp=_context.Profils.Where(x => x.Id == id).ToList();
            if (temp.Count > 0) {
                int temp2 = temp.First().IdUser;
                _context.Rejections.RemoveRange(_context.Rejections.Where(x=>x.Rejectee==temp.First().Id).ToList());
                _context.Profils.Remove(temp.First());
                _context.Users.Remove(_context.Users.Where(x=>x.Id==temp2).ToList().First());
                _context.SaveChanges();
            return 0;
            }
            return 1;
        }

        [HttpGet("ProfileAdd")]
        public int AddProfile(string login="",string haslo="", string imie = "", string nazwisko = "", string telefon = "", string email = "", sbyte plec = 2, int a1 = 0, int a2 = 0, int a3 = 0, int a4 = 0)
        {
            if (login.Length < 46 && haslo.Length < 46 && imie.Length < 46 && nazwisko.Length < 46 && telefon.Length == 9 && int.TryParse(telefon, out int ignore) && email.Contains('@') && email.Length < 46)
            {
            _context.Users.Add(new User { Login = login, Haslo = haslo });
            _context.Profils.Add(new Profil {
                IdUser = _context.Users.ToList().Last().Id,
                Imie = imie,
                Nazwisko = nazwisko,
                Telefon = telefon,
                Plec = plec,
                Atrybut1 = a1,
                Atrybut2 = a2,
                Atrybut3 = a3,
                Atrybut4 = a4 }) ;
            _context.SaveChanges();
                return 0;
            }
            return 1;
        }

        [HttpGet("ProfileUpdate")]
        public int UpdateProfile(int id,string imie="",string nazwisko="",string telefon="",string email="",int a1=0,sbyte plec=2, int a2=0, int a3=0, int a4=0) { 
            var temp= _context.Profils.Where(x => x.Id == id).First();
            if(imie!=null && imie!= "" && imie.Length < 46) temp.Imie = imie;
            if (nazwisko != null && nazwisko != "" && nazwisko.Length<46) temp.Nazwisko = nazwisko;
            if (telefon != null && telefon != "" && telefon.Length==9 && int.TryParse(telefon,out int ignore)) temp.Telefon = telefon;
            if (email != null && email != "" && email.Contains('@') && email.Length < 46) temp.Email = email;
            if (plec != 2) temp.Plec = plec;
            if (a1 != 0) temp.Atrybut1 = a1;
            if (a2 != 0) temp.Atrybut2 = a2;
            if (a3 != 0) temp.Atrybut3 = a3;
            if (a4 != 0) temp.Atrybut4 = a4;
            Console.WriteLine(imie);
            _context.SaveChanges();
            return 0;
        }


        [HttpGet("Reject")]
        public int Reject(int id1, int id2) {
            _context.Rejections.Add(new Rejection{Rejectee=id1,Rejected=id2});
            _context.SaveChanges();
            return 0;
        }

        [HttpGet("ProfileCom")]
        public List<Profil> PotencjalneProfile(int id=1)
        {
            var profil = _context.Profils.Where(x => x.Id == id).First();
            List<int> rejected = new List<int>();
            foreach (var item in _context.Rejections.Where(x => x.Rejectee == id).ToList()) {
                rejected.Add(item.Rejected);
            }
            List<ratedProfile> profile = new List<ratedProfile>();
            foreach (var item in _context.Profils.Where(x => x.Plec != profil.Plec && !rejected.Contains(x.Id)))
            {
                int i =(int)( profil.Atrybut1-item.Atrybut1+profil.Atrybut2-item.Atrybut2 + profil.Atrybut3 - item.Atrybut3 + profil.Atrybut4 - item.Atrybut4)* (int)(profil.Atrybut1 - item.Atrybut1 + profil.Atrybut2 - item.Atrybut2 + profil.Atrybut3 - item.Atrybut3 + profil.Atrybut4 - item.Atrybut4);
                profile.Add(new Models.ratedProfile(item, i));
            }
            profile=profile.OrderBy(x => x.ocena).ToList();
            return profile.Select(x=>x.profil).ToList();
        }

       
    }
}
