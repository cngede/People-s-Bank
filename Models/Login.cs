using System.ComponentModel.DataAnnotations;



namespace OnlineBank.Models
{
    public class Login
    {
        //All the square bracket functions or DataAnnotations can be used for Validations on Form submit
        [Required]
        public int? LoginId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public int? CustomerId { get; set; }
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Date Of Birth :")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(12)]
        public string? Phone { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 7)]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string? username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string? password { get; set; }
        [Required]
        public string? AccountType { get; set; }
    }

    
}