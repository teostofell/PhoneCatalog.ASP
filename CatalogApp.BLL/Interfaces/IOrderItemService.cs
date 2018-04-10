﻿using CatalogApp.BLL.BusinessModel;
using CatalogApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApp.BLL.Interfaces
{
    public interface IOrderItemService : IDisposable
    {
        Task<OperationDetails> AddToOrder(OrderItemDTO item);
        Task<OperationDetails> RemoveFromOrder(int orderItemId);
    }
}