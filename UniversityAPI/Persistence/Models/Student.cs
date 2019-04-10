using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }

    }
}
