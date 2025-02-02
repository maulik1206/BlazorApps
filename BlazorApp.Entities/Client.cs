using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "FirstName must be between 2 and 100 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "LastName must be between 2 and 100 characters.")]
        public string LastName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Email must be between 5 and 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Invalid phone number format.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string Phone { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 characters.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[a-z]).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number.")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "State must be between 2 and 100 characters.")]
        public string Street { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "State must be between 2 and 100 characters.")]
        public string City { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "State must be between 2 and 100 characters.")]
        public string State { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 5, ErrorMessage = "Invalid PostalCode.")]
        public string PostalCode { get; set; }        
    }
}
