using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Entities
{
    public class Advertise
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int OwnerId { get; set; }
        public User.Entities.User Owner { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public List<string> ImgsPathList { get; set; }
        //public List<string> ViewImgsPathList { get; set; }
        public List<User.Entities.User> BookMarks { get; set; }
        public List<BookMark> BookMarksJunction { get; set; }
    }
}
