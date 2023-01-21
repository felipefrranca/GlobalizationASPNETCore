using System.ComponentModel.DataAnnotations;

namespace GlobalizationASPNETCore.Models
{
    public class Beneficiary
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "validation_field")]
        public string Name { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "validation_field")]
        [EmailAddress(ErrorMessage = "validation_email_field")]
        public string Email { get; set; }
    }
}
