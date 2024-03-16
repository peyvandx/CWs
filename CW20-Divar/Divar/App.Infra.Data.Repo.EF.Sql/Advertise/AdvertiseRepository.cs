using App.Domain.Core.Advertise.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repo.EF.Sql.Advertise
{
    public class AdvertiseRepository : IAdvertiseRepository
    {
        public void CreateAdvertise(Domain.Core.Advertise.Entities.Advertise advertise)
        {
            throw new NotImplementedException();
        }

        public Domain.Core.Advertise.Entities.Advertise GetAdvertiseById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Core.Advertise.Entities.Advertise> GetAllAdvertises()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteAdvertise(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteAdvertise(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdvertise(Domain.Core.Advertise.Entities.Advertise updatedAdvertise)
        {
            throw new NotImplementedException();
        }
    }
}
