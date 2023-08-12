using System;
using Entity;

namespace odevortagi
{
   
    public class TeacherListViewModel
    {
        public PageInfo? PageInfo { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}