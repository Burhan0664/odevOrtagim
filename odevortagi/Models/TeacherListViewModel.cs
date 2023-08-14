using System;
using Entity;

namespace odevortagi
{
   
    public class TeacherListViewModel
    {
        public PageInfo? PageInfo { get; set; }
        public IQueryable<Teacher> Teachers { get; set; }
    }
}