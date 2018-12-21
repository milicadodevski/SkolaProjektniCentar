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
    using System.Web;

    public class Skola
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skola()
        {
            this.Osobas = new HashSet<Osoba>();
        }
        public long IdSkole { get; set; }
        [Required]
        //[RegularExpression(@".{2,30}$", ErrorMessage = "Unesite vrednost izmedju 2 i 35 karaktera")]
        public string Naziv { get; set; }
        [Required]
        //[RegularExpression(@".{2,40}$", ErrorMessage = "Unesite vrednost izmedju 2 i 40 karaktera")]
        public string Adresa { get; set; }
        [Required]
       // [RegularExpression(@"[a-zA-Z ]{2,30}$", ErrorMessage = "Unesite vrednost izmedju 2 i 30 karaktera")]
        public string Opstina { get; set; }
        [Required]
        [Display(Name ="Postanski broj")]
        //[RegularExpression(@"^(\d{5})$", ErrorMessage = "Unesite 5 cifara")]
        public string PostanskiBroj { get; set; }
        [Required]
        [Display(Name = "Maticni broj")]
       // [RegularExpression(@"^(\d{8})$", ErrorMessage = "Unesite broj od 8 cifara")]
        public string MaticniBroj { get; set; }
        [Required]
        //[RegularExpression(@"^(\d{9})$", ErrorMessage = "Unesite broj od 9 cifara")]
        public string PIB { get; set; }
        [Required]
        [Display(Name = "Broj racuna")]
      //  [RegularExpression(@"^(\d{9})$", ErrorMessage = "Unesite vrednost od 17 do 9 cifara")]
        public string BrojRacuna { get; set; }
        [Required]
        [Display(Name = "Web stranica")]
        [Url]
        public string WebStranica { get; set; }
        public string Pecat { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Granica iznosi 255 karaktera.")]
        public string Beleska { get; set; }
        [Display(Name = "Ucitaj sliku")]
        public HttpPostedFileBase ImageUpload { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Osoba> Osobas { get; set; }
    }
}