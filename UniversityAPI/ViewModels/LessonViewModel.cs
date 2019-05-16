using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UniversityAPI.Persistence.Models;

namespace UniversityAPI.ViewModels
{
    public class LessonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DayNumber { get; set; }
        public string Type { get; set; }
        public Teacher Teacher { get; set; }
        public string BeginHour { get; set; }
        public string Duration { get; set; }
        public string Cabinet { get; set; }
        public string Week { get; set; }
        public Schedule Schedule { get; set; }
    }
}
