using System.ComponentModel.DataAnnotations;

namespace BuyGroceriesOnline.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Display(Name = "First Name")]         
        [StringLength(15, MinimumLength = 1)]                     
        [Required(ErrorMessage = "Please Enter the First Name ")]
        [MaxLength(15, ErrorMessage = "First Name can have Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-Z\s]{1,10}$", ErrorMessage = "Numbers and Special Characters are not allowed. Please enter the valid Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(10, MinimumLength = 1)]
        [Required(ErrorMessage = "Please Enter the Last Name ")]
        [MaxLength(10, ErrorMessage = "First Name can have Maximum 10 characters")]
        [RegularExpression(@"^[a-zA-Z\s]{1,10}$", ErrorMessage = "Numbers and Special Characters are not allowed. Please enter the valid Name")]
        public string LastName { get; set; }

        
        [StringLength(10, MinimumLength = 1)]
        [Required(ErrorMessage = "Please Enter your Country Name ")]
        [MaxLength(10, ErrorMessage = "Country can have Maximum 10 characters")]
        [RegularExpression(@"^[a-zA-Z\s]{1,10}$", ErrorMessage = "Numbers and Special Characters are not allowed. Please enter the valid Country")]
        public string Country { get; set; }

        [StringLength(15, MinimumLength = 1)]
        [Required(ErrorMessage = "Please Enter your City Name ")]
        [MaxLength(15, ErrorMessage = "City can have Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-Z\s]{1,10}$", ErrorMessage = "Numbers and Special Characters are not allowed. Please enter the valid City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter your Feedback ")]
        public string FeedBack{ get; set; }
    }
}
