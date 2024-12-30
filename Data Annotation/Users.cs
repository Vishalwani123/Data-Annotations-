using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Annotation
{
    internal class Users
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18,60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
        public string Department { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
}
