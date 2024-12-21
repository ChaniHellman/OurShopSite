﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;




namespace Repositories
{
    public class Productrepository : IProductrepository
    {
        ShopApiContext _shopContext;
        public Productrepository(ShopApiContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<List<Product>> getProducts()
        {
            List<Product> allProducts = await _shopContext.Products.Include(p => p.Category).ToListAsync();
            return allProducts;
        }


    }
}
