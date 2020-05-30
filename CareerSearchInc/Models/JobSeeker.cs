using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchInc.Models
{
    //Job seekers details
    public class JobSeeker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string HighestQualification { get; set; }
        public string CourseOfStudy { get; set; }
        public string Grade { get; set; }
        public int GraduationYear { get; set; }
        public int YrsOfExp { get; set; }
        public string FunctionalAreas { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public IEnumerable<Country> AllCountry { get; set; }
        //public IEnumerable<HighestQualification> AllQualification { get; set; }
        //public IEnumerable<RecruitmentServices> Allservices { get; set; }
        //public IEnumerable<Walkings> Walking { get; set; }
    }
}
