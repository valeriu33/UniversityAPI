using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
