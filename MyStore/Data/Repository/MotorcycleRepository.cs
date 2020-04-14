using Microsoft.EntityFrameworkCore;
using MyStore.Data.Entities;
using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Repository
{
    public class MotorcycleRepository : IAllMotors
    {
        private readonly AppDbContent appDbContent;
        public MotorcycleRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Motorcycle> Motorcycles => appDbContent.Motorcycle.Include(c => c.Category);

        public IEnumerable<Motorcycle> getFavMotorcycles => appDbContent.Motorcycle.Where(p => p.isFavorite).Include(c => c.Category);

        public Motorcycle getObjectMotorcycle(int motorcycleId) => appDbContent.Motorcycle.FirstOrDefault(p => p.id == motorcycleId);
    }
}
