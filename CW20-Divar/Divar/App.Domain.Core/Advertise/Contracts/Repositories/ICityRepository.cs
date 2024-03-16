using App.Domain.Core.Advertise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Contracts.Repositories
{
    public interface ICityRepository
    {
        void CreateCity(City city);
        City GetCityById(int id);
        List<City> GetAllCities();
        void UpdateCity(City updatedCity);
        void SoftDeleteCity(int id);
        void HardDeleteCity(int id);
    }
}
