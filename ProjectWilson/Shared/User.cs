using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWilson.Shared
{
    public class User
    {
        [Required(ErrorMessage = "Enter a username u muppet")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter a password u muppet")]
        public string Password { get; set; }
    }
}
