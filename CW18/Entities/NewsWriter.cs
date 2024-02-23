using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NewsWriter
    {
        public int Id { get; set; }
        [DisplayName("نام")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("نام خانوادگی")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("ایمیل")]
        [Required]
        public string Email { get; set; }
        [DisplayName("پسورد")]
        [Required]
        public string Password { get; set; }
        public List<News> NewsList { get; set; }

    }
}
