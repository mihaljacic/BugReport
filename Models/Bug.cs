using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReport.Models
{
    public class Bug
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ime Buga")]
        public string BugName { get; set; }

        [Required]
        [Display(Name = "Datum otvaranja")]
        public DateTime DateOpen { get; set; }

        [Required]
        [Display(Name = "Opis buga")]
        public string BugDescription { get; set; }

        [Display(Name = "Zatvoren")]
        public bool IsClosed { get; set; }

        [Display(Name = "Riješenje buga")]
        public string BugResolution { get; set; }
    }
}
