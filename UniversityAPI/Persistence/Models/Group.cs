using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Group
    {
        public int Id { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
