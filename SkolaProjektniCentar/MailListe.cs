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

    public class MailListe
    {
        public long IdMaila { get; set; }
        [Required(ErrorMessage ="Unesi adresu")]
        public string Adresa { get; set; }
        public virtual TipMaila TipMaila { get; set; }
        public long IdTipaMaila { get; set; }
        public virtual Osoba Osoba { get; set; }
        public long IdOsobe { get; set; }
    
        
        
    }
}
