using App.Domain.Core.Advertise.Contracts.Repositories;
using App.Domain.Core.Advertise.Contracts.Services;
using App.Infra.Data.Repo.EF.Sql.Advertise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Advertise
{

    public class AdvertiseService : IAdvertiseService
    {
        private readonly IAdvertiseRepository _advertiseRepository = new AdvertiseRepository();

        // service haii ke mikhan az ui seda zade beshan nabayad inputeshoun Entity bashe, bayad DTO bashe. yani ui be entity kari nadashte bashe.
        public void CreateAdvertise(Core.Advertise.Entities.Advertise advertise)
        {
            throw new NotImplementedException();
        }

        public Core.Advertise.Entities.Advertise GetAdvertiseById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Core.Advertise.Entities.Advertise> GetAllAdvertises()
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

        public void UpdateAdvertise(Core.Advertise.Entities.Advertise updatedAdvertise)
        {
            throw new NotImplementedException();
        }
    }
}
