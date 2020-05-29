using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CareerSearchInc.Models
{
    
        //Walking interview or non walking interview
        public enum Walkings
        {
        [Display(Name = "Walking")]
        walk = 0,
        [Display(Name = "Not Walking")]
        not_walking = 1,
        
        }
    
}