using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityAPI.Persistence.Models;

namespace UniversityAPI.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public long IDNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Group Group { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
    }
}
