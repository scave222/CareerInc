using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerSearchInc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareerSearchInc.Controllers
{
    public class JobRecuiterController : Controller
    {
        public IActionResult JobRecruiterList()
        {
            List<JobRecuiter> jobRecruiter = new List<JobRecuiter>()
            {
                new JobRecuiter { CompanyName = "Apple Stores", Industry = "Marketting", Country = "USA", Address = "7 Kingsway Street",Email = "apple@gmail.com", FunctionalArea = "Sales representative", JobLocation = "Texas",  HighestQualification ="BSc", Experience = 0, RecruitmentService = "Contract", WalkingOrNot = "Walking",date = "11/6/2020",Top = "Top"},
                new JobRecuiter { CompanyName = "Blue Ray PLC", Industry = "Engineering", Country = "USA", Address = "108 Belvin Street",Email = "rayblue@gmail.com", FunctionalArea = "Administration", JobLocation = "Chicago",  HighestQualification ="NCE", Experience = 5, RecruitmentService = "Temporary", WalkingOrNot = "Not_Walking"},
                new JobRecuiter { CompanyName = "Dikat and Sons LTD", Industry = "Information_technology", Country = "USA", Address = "54 Obama Street",Email = "dikat@gmail.com", FunctionalArea = "Accountant", JobLocation = "New York",  HighestQualification ="HND", Experience = 2, RecruitmentService = "PartTime", WalkingOrNot = "Not_Walking", Top = "Top"},
                new JobRecuiter { CompanyName = "Smith Enterprise", Industry = "Sales", Country = "USA", Address = "66 Malcomstreet",Email = "smith@gmail.com", FunctionalArea = "Business development officer", JobLocation = "Texas",  HighestQualification ="PHD", Experience = 1, RecruitmentService = "FullTime", WalkingOrNot = "Walking",date = "5/7/2020", Top = "Top"},
                new JobRecuiter { CompanyName = "Johnson and Co", Industry = "Finance", Country = "USA", Address = "87 Kingsway Street",Email = "johnson@gmail.com", FunctionalArea = "Mechanical Engineer", JobLocation = "Sanfrancisco",  HighestQualification ="MSC", Experience = 0, RecruitmentService = "FullTime", WalkingOrNot = "Walking",date = "23/7/2020", Top = "Top"},
                new JobRecuiter { CompanyName = "Lonard Ltd", Industry = "Sales", Country = "USA", Address = "22 lodash street Street",Email = "lonard@gmail.com", FunctionalArea = "Accountant", JobLocation = "Chicago",  HighestQualification ="MSC", Experience = 3, RecruitmentService = "FullTime", WalkingOrNot = "Walking",date = "27/8/2020"},
                new JobRecuiter { CompanyName = "Matt and Co", Industry = "Finance", Country = "USA", Address = "72 Butt street",Email = "matt@gmail.com", FunctionalArea = "Sales representative", JobLocation = "Sanfrancisco",  HighestQualification ="ND", Experience = 5, RecruitmentService = "PartTime", WalkingOrNot = "Walking",date = "2/9/2020", Top = "Top"},
                new JobRecuiter { CompanyName = "Showbo PLC", Industry = "Finance", Country = "USA", Address = "42 Daron close",Email = "shobo@gmail.com", FunctionalArea = "Mechanical Engineer", JobLocation = "New York",  HighestQualification ="BSc", Experience = 3, RecruitmentService = "PartTime", WalkingOrNot = "Walking",date = "11/9/2020"},
                new JobRecuiter { CompanyName = "Delli Ltd", Industry = "Finance", Country = "USA", Address = "96 Noble street",Email = "delli@gmail.com", FunctionalArea = "Mechanical Engineer", JobLocation = "Texas",  HighestQualification ="PHD", Experience = 4, RecruitmentService = "Temporary", WalkingOrNot = "Walking",date = "15/9/2020", Top = "Top"},
                new JobRecuiter { CompanyName = "Daff co", Industry = "Finance", Country = "USA", Address = "12 Fall street",Email = "daff@gmail.com", FunctionalArea = "Business development officer", JobLocation = "Geogia",  HighestQualification ="ND", Experience = 4, RecruitmentService = "Contract", WalkingOrNot = "Not_Walking", Top = "Top"},
                new JobRecuiter { CompanyName = "Seal Ltd", Industry = "Finance", Country = "USA", Address = "42 Ball street",Email = "seal@gmail.com", FunctionalArea = "Administration", JobLocation = "Sanfrancisco",  HighestQualification ="NCE", Experience = 1, RecruitmentService = "Temporary", WalkingOrNot = "Not_Walking", Top = "Top"},

            };
            return View(jobRecruiter);

            
        }
        public IActionResult PostJob()
        {
            return View();
        }


        public IActionResult SearchJobs()
        {
            JobRecruiterList();
            return View();
        }

        
        public IActionResult Walking()
        {
            JobRecruiterList();
            return View();
        }

        public IActionResult TopJobs()
        {
            JobRecruiterList();
            return View();
        }

        public IActionResult AllJobs()
        {
            JobRecruiterList();
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
    }
}
                                            
