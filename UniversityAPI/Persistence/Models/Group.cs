using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
