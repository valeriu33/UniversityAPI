using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string AddInfo { get; set; }
        public string Photo { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
