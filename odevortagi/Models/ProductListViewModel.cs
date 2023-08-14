using System;
using Entity;

namespace odevortagi
{
   
    public class ProductListViewModel
    {
        public PageInfo? PageInfo { get; set; }
        public IQueryable<Student> Students { get; set; }
    }
}