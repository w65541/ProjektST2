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

        [HttpGet]
        public List<Profil> Get()
        {
            Console.WriteLine("Połączone");
            return _context.Profils.ToList();
        }

        [HttpGet("Login")]
        public int GetId(string login,string password)
        {
            Console.WriteLine("Połączone");
            var temp = _context.Users.Where(x => x.Login.Equals(login) && x.Haslo.Equals(password)).ToList();
            if (temp.Count > 0) return temp.First().Id;
            return 0;
        }

        [HttpGet("ProfileGet")]
        public Profil GetProfil(int id)
        {
            var temp = _context.Profils.Where(x => x.Id == id).ToList();
            if (temp.Count > 0) return temp.First();
            return null;
        }



        [HttpPatch("ProfileDelete")]
        public void DeleteProfile(int id)
        {
            var temp=_context.Profils.Where(x => x.Id == id).ToList();
            if(temp.Count>0) _context.Profils.Remove(temp.First());   
                
        }

        [HttpPost("ProfileAdd")]
        public void AddProfile( string imie = "", string nazwisko = "", string telefon = "", int a1 = 0, int a2 = 0, int a3 = 0, int a4 = 0)
        {
            _context.Profils.Add(new Profil { 
            Imie = imie,
            Nazwisko = nazwisko,
            Telefon = telefon,
            Atrybut1 = a1,
            Atrybut2 = a2,
            Atrybut3 = a3,
            Atrybut4 = a4});
            _context.SaveChanges();
        }

        [HttpGet("ProfileUpdate")]
        public void UpdateProfile(int id,string imie="",string nazwisko="",string telefon="",string email="",int a1=0, int a2=0, int a3=0, int a4=0) { 
            var temp= _context.Profils.Where(x => x.Id == id).First();
            if(imie!="")temp.Imie = imie;
            if (nazwisko != "") temp.Nazwisko = nazwisko;
            if (telefon != "") temp.Telefon = telefon;
            if (email != "") temp.Email = email;
            if (a1 != 0) temp.Atrybut1 = a1;
            if (a2 != 0) temp.Atrybut2 = a2;
            if (a3 != 0) temp.Atrybut3 = a3;
            if (a4 != 0) temp.Atrybut4 = a4;
            Console.WriteLine(imie);
            _context.SaveChanges();
        }


        [HttpPost("Reject")]
        public void reject(int id1, int id2) {
            _context.Rejections.Add(new Rejection{Rejectee=id1,Rejected=id2});
            _context.SaveChanges();
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
            Console.WriteLine("dupa "+profile[0].ocena);
            return profile.Select(x=>x.profil).ToList();
        }

       
    }
}
