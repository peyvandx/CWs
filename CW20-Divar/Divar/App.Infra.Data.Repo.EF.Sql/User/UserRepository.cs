using App.Domain.Core.User.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repo.EF.Sql.User
{
    internal class UserRepository : IUserRepository
    {
        public void CreateUser(Domain.Core.User.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Core.User.Entities.User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Domain.Core.User.Entities.User GetUserById(int id)
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

        public void UpdateUser(Domain.Core.User.Entities.User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
