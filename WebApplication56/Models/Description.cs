using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication56.Models
{
    public class Description
    {
        [Key]
        public int desc { get; set; }
        public string ReturnUrl { get; set; }

    }
}