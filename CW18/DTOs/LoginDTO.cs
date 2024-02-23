using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class LoginDTO
    {
        [DisplayName("ایمیل")]
        [Required]
        public string Email { get; set; }
        [DisplayName("پسورد")]
        [Required]
        public string Password { get; set; }
    }
}
