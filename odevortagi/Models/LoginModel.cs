using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}