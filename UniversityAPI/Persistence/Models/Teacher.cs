using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Telephone { get; set; }
        public string AddInfo { get; set; }
        public string Photo { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
