using System.ComponentModel.DataAnnotations;
namespace WEBSITE.Models
{
    public class LegalAdvisoryModel
    {
        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Preferred Date is required")]
        [Display(Name = "Preferred Date")]
        [DataType(DataType.Date)]
        public DateOnly PreferredDate { get; set; }
    }
}
