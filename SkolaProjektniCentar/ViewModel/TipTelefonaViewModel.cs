using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SkolaProjektniCentar.Models;

namespace SkolaProjektniCentar.ViewModel
{
    public class TipTelefonaViewModel
    {
        public TipTelefona TipTelefona { get; set; }
        public long IdTipaTelefona { get; set; }
        [Required]
        public string Tip { get; set; }
    }
}
