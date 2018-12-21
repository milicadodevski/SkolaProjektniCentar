using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkolaProjektniCentar.ViewModel
{
    public class KorisnikViewModel
    {
        public Korisnik Korisnik { get; set; }
        public long IdKorisnika { get; set; }
        [Required]
        [Display(Name = "Korisnicko ime")]
        public string KorisnickoIme { get; set; }
        [Required]
        [Display(Name = "Lozinka")]
        public string Lozinka { get; set; }
        [Required]
        [Display(Name = "Pravo Pristupa")]
        public int PravoPristupa { get; set; }
        public string LoginError { get; internal set; }
    }
}