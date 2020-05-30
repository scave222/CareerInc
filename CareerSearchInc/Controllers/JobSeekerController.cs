using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerSearchInc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareerSearchInc.Controllers
{
    public class JobSeekerController : Controller
    {
        public IActionResult JobSeekersList()
        {
            
            List<JobSeeker> jobSeekers = new List<JobSeeker>()
            {
                new JobSeeker {FirstName = "Mark", LastName = "Simon", DOB =Convert.ToDateTime("12/04/2000"), Sex = "Male", Country = "USA", Phone = "7532359864", Email = "simon@gmail.com", Address = "32 Bell street", HighestQualification = "BSc", CourseOfStudy = "Business Administration", Grade = "Second_Class_Lower", GraduationYear = 2017, YrsOfExp = 3, FunctionalAreas = "Sales representative",Password = "23,68dfgr", ConfirmPassword = "23,68dfgr"},
                new JobSeeker {FirstName = "Ruth", LastName = "Julius", DOB = Convert.ToDateTime("18/08/1990"), Sex = "Female", Country = "USA", Phone = "7535432187", Email = "ruth@gmail.com", Address = "421 Palace street", HighestQualification = "ND", CourseOfStudy = "Banking and Finance", Grade = "Pass", GraduationYear = 2014, YrsOfExp = 1, FunctionalAreas = "Accountant",Password = "5f,2dfgr", ConfirmPassword = "5f,2dfgr"},
                new JobSeeker {FirstName = "Sharon", LastName = "Stone", DOB = Convert.ToDateTime("02/01/1995"), Sex = "Female", Country = "USA", Phone = "7538874264", Email = "sharon@gmail.com", Address = "72 Well street", HighestQualification = "HND", CourseOfStudy = "Mass communication", Grade = "Distinction", GraduationYear = 2011, YrsOfExp = 4, FunctionalAreas = "Administration",Password = "1d4.6ddr", ConfirmPassword = "1d4.6ddr"},
                new JobSeeker {FirstName = "Lovren", LastName = "Becker", DOB = Convert.ToDateTime("22/06/1989"), Sex = "Male", Country = "USA", Phone = "7534321784", Email = "becker@gmail.com", Address = "81 Ring street", HighestQualification = "BSc", CourseOfStudy = "Mechanical Engineer", Grade = "First_Class", GraduationYear = 2013, YrsOfExp = 0, FunctionalAreas = "Mechanical Engineer",Password = "bg4ml.89", ConfirmPassword = "bg4ml.89"},
                new JobSeeker {FirstName = "Sterling", LastName = "Raheem", DOB = Convert.ToDateTime("30/11/1999"), Sex = "Male", Country = "USA", Phone = "7538904324", Email = "sterling@gmail.com", Address = "21 Long street", HighestQualification = "BSc", CourseOfStudy = "Chemical Engineer", Grade = "Second_Class_Upper", GraduationYear = 2016, YrsOfExp = 2, FunctionalAreas = "Business development officer",Password = "nhg9-td2s", ConfirmPassword = "nhg9-td2s"},

            };
            var  AllCountry = Enum.GetValues(typeof(Country)).Cast<Country>().ToList();
            return View();
        }
        public IActionResult SignUpJob()
        {
            return View();
        }

        public IActionResult SearchProfile()
        {
            return View();
        }
    }
}