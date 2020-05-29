using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CareerSearchInc.Models
{
    public enum HighestQualification
    {
        [Display(Name = "Secondary School")]
        sec = 0,
        [Display(Name = "ND")]
        nd = 1,
        [Display(Name = "HND")]
        hnd = 2,
        [Display(Name = "BSc")]
        bsc = 3,
        [Display(Name = "MSc")]
        msc = 4,
        [Display(Name = "PHD")]
        phd = 5,
    }
}
