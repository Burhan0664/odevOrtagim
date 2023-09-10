using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Majority { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public string? Gender { get; set; }
    }
}