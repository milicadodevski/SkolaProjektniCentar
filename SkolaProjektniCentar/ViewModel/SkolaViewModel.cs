using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using SkolaProjektniCentar.Models;

namespace SkolaProjektniCentar.ViewModel
{
    public class SkolaViewModel
    {
        public Skola Skola { get; set; }
        public long IdSkole { get; set; }
        [Required]
        //[RegularExpression(@"^([a-zA-Z ]{2,25}(.*?))+$", ErrorMessage = "Prihvacena mogu biti samo slova i razmaci, u rasponu od 2 do 25 karaktera")]
        public string Naziv { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Opstina { get; set; }
        [Required]
        [Display(Name = "Postanski broj")]
        public string PostanskiBroj { get; set; }
        [Required]
        [Display(Name = "Maticni broj")]
        //[RegularExpression(@"^(\d{8})$", ErrorMessage = "Unesite broj od 8 cifara")]
        public string MaticniBroj { get; set; }
        [Required]
        public string PIB { get; set; }
        [Required]
        [Display(Name = "Broj racuna")]
        public string BrojRacuna { get; set; }
        public string Pecat { get; set; }
        [Required]
        [Display(Name = "Web stranica")]
        public string WebStranica { get; set; }
        [Required]
        public string Beleska { get; set; }
        [Display(Name = "Ucitaj sliku")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}