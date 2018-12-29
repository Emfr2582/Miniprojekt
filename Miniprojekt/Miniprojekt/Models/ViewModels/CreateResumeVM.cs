using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt.Models.ViewModels
{
    public class CreateResumeVM
    {
        public int Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public string LastName { get; set; }

        [Required()]
        public string Address { get; set; }

        [Required()]
        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }

        [Required()]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Invalid e-mail adress")]
        public string Email { get; set; }

        [Display(Name = "Education")]
        public SelectListItem[] EducationItems { get; set; }

        public string[] SelectedEducationValue { get; set; }

        [Display(Name = "Gender")]
        public SelectListItem[] Gender { get; set; }
            public SelectListItem[] Gender = new SelectListItem[]
            {
                new SelectListItem { Value = "1", Text = "Kvinna"},
                new SelectListItem {Value = "2", Text = "Man"},
                new SelectListItem {Value = "3", Text = "Annat"},
                new SelectListItem {Value = "4", Text = "Vill ej uppge"}
            };
        public int[] SelectedGenderValues{ get; set; }
    }
}
