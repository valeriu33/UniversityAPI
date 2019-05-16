using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityAPI.Persistence.Models;

namespace UniversityAPI.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
