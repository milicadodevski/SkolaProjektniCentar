using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkolaProjektniCentar.ViewModel
{
    public class TipMailaViewModel
    {
        public long IdTipaMaila { get; set; }
        [Required]
        public string Tip { get; set; }
    }
}