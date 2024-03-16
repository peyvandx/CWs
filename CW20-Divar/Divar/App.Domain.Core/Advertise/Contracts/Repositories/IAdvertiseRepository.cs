using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Contracts.Repositories
{
    public interface IAdvertiseRepository
    {
        void CreateAdvertise(Advertise.Entities.Advertise advertise);
        Advertise.Entities.Advertise GetAdvertiseById(int id);
        List<Advertise.Entities.Advertise> GetAllAdvertises();
        void UpdateAdvertise(Advertise.Entities.Advertise updatedAdvertise);
        void SoftDeleteAdvertise(int id);
        void HardDeleteAdvertise(int id);
    }
}
