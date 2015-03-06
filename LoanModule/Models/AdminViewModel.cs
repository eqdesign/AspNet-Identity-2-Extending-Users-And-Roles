using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LoanModule.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        // Add the user properties:
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string JobTitle { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        [Display(Name = "NMLS #")]
        public System.Nullable<int> NMLS { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        [Required]
        [Display(Name = "Branch")]
        public string Branch { get; set; }
        public string Photo { get; set; }
        
        // Add the Address Info:
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        // Use a sensible display name for views:
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }


        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}