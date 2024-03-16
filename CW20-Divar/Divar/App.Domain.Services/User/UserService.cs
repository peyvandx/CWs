using App.Domain.Core.User.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.User
{
    internal class UserService : IUserService
    {
        public void CreateUser(Core.User.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public List<Core.User.Entities.User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Core.User.Entities.User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Core.User.Entities.User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
