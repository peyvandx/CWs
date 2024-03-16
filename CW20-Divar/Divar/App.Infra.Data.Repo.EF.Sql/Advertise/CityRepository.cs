using App.Domain.Core.Advertise.Contracts.Repositories;
using App.Domain.Core.Advertise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repo.EF.Sql.Advertise
{
    internal class CityRepository : ICityRepository
    {
        public void CreateCity(City city)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAllCities()
        {
            throw new NotImplementedException();
        }

        public City GetCityById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteCity(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteCity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(City updatedCity)
        {
            throw new NotImplementedException();
        }
    }
}
