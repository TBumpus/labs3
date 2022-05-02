using System.ComponentModel.DataAnnotations;

namespace coffeeShopRegistrationLab.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter First Name my guy")]
        [Display(Name = "First Name")]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
