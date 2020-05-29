using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CareerSearchInc.Models
{
    public enum Grade
    {
        [Display (Name = "First Class")]
        first = 0,
        [Display (Name = "Distiction")]
        distiction = 1,
        [Display (Name = "Second Class Upper")]
        second = 2,
        [Display (Name = "Third Class")]
        third = 3,
        [Display (Name = "Pass")]
        pass = 4,
        
    };
}
