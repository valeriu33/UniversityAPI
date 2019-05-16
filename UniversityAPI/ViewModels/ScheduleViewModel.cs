using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityAPI.Persistence.Models;

namespace UniversityAPI.ViewModels
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
