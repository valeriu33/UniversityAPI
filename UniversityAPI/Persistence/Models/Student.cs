using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAPI.Persistence.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(13)]
        [MinLength(13)]
        public string IDNP { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string Photo { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

    }
}
