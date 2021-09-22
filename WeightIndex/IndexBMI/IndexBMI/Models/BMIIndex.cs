using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndexBMI.Models
{
    public class BMIIndex
    {
        [Required(ErrorMessage = "Please enter your height")]
        [Display(Name = "Height (cm)")]
        public double Height { get; set; }
        [Required(ErrorMessage = "Please enter your weight")]
        [Display(Name = "Weight (kg)")]
        public double Weight { get; set; }
        public string Result { get; set; }
    }
}
