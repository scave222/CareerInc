using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CareerSearchInc.Models
{
    public enum Industry
    {
        [Display (Name = "Accounting")]
            Account = 0,
        [Display(Name = "Marketting")]
        Marketting = 1,
        [Display(Name = "Engineering")]
        Engineering = 2,
        [Display(Name = "Information technology")]
        Information = 3,
        [Display(Name = "Sales")]
        Sales = 4,
        [Display(Name = "Finance")]
        Finance = 5,
    }
}
