using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.Contracts.Repositories
{
    public interface IUserRepository
    {
        void CreateUser(User.Entities.User user);
        User.Entities.User GetUserById(int id);
        List<User.Entities.User> GetAllUsers();
        void UpdateUser(User.Entities.User updatedUser);
        void SoftDeleteUser(int id);
        void HardDeleteUser(int id);
    }
}
