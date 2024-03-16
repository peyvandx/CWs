using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Domain.Core.User.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("نام")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("ایمیل")]
        public string Email { get; set; }

        [Required]
        [DisplayName("پسورد")]
        public string Password { get; set; }

        [Required]
        [DisplayName("تکرار پسورد")]
        [Compare("Password", ErrorMessage = "پسورد و تکرار پسورد با هم برابر نیستند")]
        public string ConfirmPassword { get; set; }

        public List<Book.Entities.Book> BorrowedBooks { get; set; }
    }
}
