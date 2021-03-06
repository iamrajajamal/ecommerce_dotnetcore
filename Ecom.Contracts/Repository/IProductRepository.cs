﻿using Ecom.Domain.Entities.Catalog;
using System.Collections.Generic;

namespace Ecom.Contracts.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProducts();
    }
}
