using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebapp.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Alphabet is Not allowed")]
        [Required]
        public string Firstname { get; set; }
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Alphabet is Not allowed")]
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[9876]\d{9}", ErrorMessage = "Please Enter Validate Mobile Number")]
        public string Mobile { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public int Fees { get; set; }
        
    }
}
