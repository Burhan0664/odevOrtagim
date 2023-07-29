using System;

namespace Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Majority { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; } =DateTime.Now;

    }
}