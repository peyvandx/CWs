using AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class AdminServices : IAdminServices
    {
        public void AutoLoginAdminByEmail(string email)
        {
            var db = new DefaultDbContext();
            OnlineStuff.OnlineAdmin = db.Admins.FirstOrDefault(a => a.Email == email);
        }
    }
}
