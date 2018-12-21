//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkolaProjektniCentar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class KontaktTelefon
    {
        public long IdTelefona { get; set; }
        [Required]
        [Display(Name ="Broj telefona")]
        public string BrojTelefona { get; set; }
        [Required]
        public int Lokal { get; set; }
        public virtual TipTelefona TipTelefona { get; set; }
        [Display(Name = "Tip telefona")]
        public long IdTipaTelefona { get; set; }
        public virtual Osoba Osoba { get; set; }
        [Display(Name = "Osoba")]
        public long IdOsobe { get; set; }
        
        public IEnumerable<TipTelefona> Tipovi { get; set; }
        public IEnumerable<Osoba> Osobe { get; set; }
    }
}
