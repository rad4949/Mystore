using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Interfaces
{
    public interface IMotoCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
