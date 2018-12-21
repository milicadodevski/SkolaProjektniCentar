using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkolaProjektniCentar.ViewModel
{
    public class KontaktTelefonViewModel
    {
        public KontaktTelefon KontaktTelefon { get; set; }
        public long IdTelefona { get; set; }
        [Required]
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }
        [Required]
        public int Lokal { get; set; }
        public virtual TipTelefona TipTelefona { get; set; }
        public long IdTipaTelefona { get; set; }
        public Osoba Osoba { get; set; }
        public long IdOsobe { get; set; }
        

        public IEnumerable<TipTelefona> Tipovi { get; set; }
        public IEnumerable<Osoba> Osobe { get; set; }
    }
}