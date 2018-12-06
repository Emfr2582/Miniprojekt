using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt.Models.ViewModels
{
    public class CreateResumeVM
    {
        [Required()]
        public string Name { get; set; }

        [Required()]
        public string LastName { get; set; }

        [Required()]
        public string Address { get; set; }

        [Required()]
        public string PhoneNumber { get; set; }

        [Required()]
        [Display(Name ="E-mail")]
        [EmailAddress(ErrorMessage ="Invalid e-mail adress")]
        public string Email { get; set; }

    }
}
