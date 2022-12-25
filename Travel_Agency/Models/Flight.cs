using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Travel_Agency.Models
{
    public class Flight
    {
        [Key]
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Id must be 6 letters")]
        public string id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Id must be 6 letters")]
        public string originCountry { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Origin country must be between 2 and 20 letters")]
        public string destination { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Destination must be between 2 and 20 letters")]
        public string Date { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Date must be 10 letters")]
        public string time { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Time must be 4 letters")]
        public string price { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Price must be between 1 and 30 letters")]
        public string type { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "first name must be between 2 and 30 letters")]
        public string oneWayOrTwo { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "first name must be between 2 and 30 letters")]
        public string tickets { get; set; }
        
    }
}