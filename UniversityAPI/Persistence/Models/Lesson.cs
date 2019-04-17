using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        public int DayNumber { get; set; }
        [MaxLength(20)]
        public string Type { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [MaxLength(5)]
        public string BeginHour { get; set; }
        [MaxLength(5)]
        public string Duration { get; set; }
        [MaxLength(10)]
        public string Cabinet { get; set; }
        [MaxLength(5)]
        public string Week { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
