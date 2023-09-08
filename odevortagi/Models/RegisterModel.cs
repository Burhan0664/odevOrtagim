using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace Models
{
    public class RegisterModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]


        public string LastName { get; set; }

    }
}