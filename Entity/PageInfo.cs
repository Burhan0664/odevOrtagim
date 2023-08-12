using System;

namespace Entity
{
    public class PageInfo
    {
        public int Id { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPage()
        {
           return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
    }
}