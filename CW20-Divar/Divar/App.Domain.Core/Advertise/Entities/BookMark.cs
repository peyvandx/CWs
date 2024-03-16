using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Entities
{
    public class BookMark
    {
        //public int Id { get; set; }

        public int UserId { get; set; }
        public User.Entities.User User { get; set; }

        public int AdvertiseId { get; set; }
        public Advertise Advertise { get; set; }
    }
}
