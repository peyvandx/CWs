using App.Domain.Core.Advertise.Contracts.Repositories;
using App.Domain.Core.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repo.EF.Sql.Advertise
{
    public class BookMarkRepository : IBookMarkRepository
    {
        public void AddToBookMarksList(Domain.Core.Advertise.Entities.Advertise advertise, User user)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromBookMarksList(Domain.Core.Advertise.Entities.Advertise advertise, User user)
        {
            throw new NotImplementedException();
        }
    }
}
