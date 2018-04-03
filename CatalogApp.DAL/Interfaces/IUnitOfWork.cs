﻿using CatalogApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Phone> Phones { get; }
        IRepository<Brand> Brands { get; }
        IRepository<OS> OperatingSystems { get; }
        IRepository<ScreenResolution> ScreenResolutions { get; }
        IRepository<Order> Orders { get; }
        IRepository<City> Cities { get; }
        IRepository<Photo> Photos { get; }
        IRepository<OrderItem> OrderItems { get; }

        Task SaveAsync();
    }
}
