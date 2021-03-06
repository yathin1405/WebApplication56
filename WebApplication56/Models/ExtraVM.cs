using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication56.Models
{
    public class ExtraVM
    {
        [Key]

        public string exvm { get; set; }
        [DisplayName("Extra Name"), Required]
        public bool Gym { get; set; }
        public bool Laundry { get; set; }
        public bool Parking { get; set; }
        [DisplayName("Basic Cost"), Required]
        public double BasicCost { get; set; }
        [Required]
        [DisplayName("Source")]
        public string source { get; set; }
    }
}
