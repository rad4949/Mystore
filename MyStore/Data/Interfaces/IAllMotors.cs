using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Interfaces
{
    public interface IAllMotors
    {
        IEnumerable<Motorcycle> Motorcycles { get; }
        IEnumerable<Motorcycle> getFavMotorcycles { get; }
        Motorcycle getObjectMotorcycle(int motorcycleId);

    }
}
