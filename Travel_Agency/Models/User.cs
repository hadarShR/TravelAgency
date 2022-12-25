using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Travel_Agency.Models
{
    public class User
    {
        [Required]
        public string Password { get; set; }
        [Key]
        [Required]
        public string userName { get; set; }
        public string card { get; set; }
    }
}