﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BussinesLogic.Logic
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly MarketDbContext _context;
        public ProductoRepository(MarketDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Producto>> GetProductoAsync()
        {
            return await _context.Producto.ToListAsync();
        }

        public async Task<Producto> GetProductoByIdAsync(int id)
        {
           return  await _context.Producto.FindAsync(id);
        }
    }

}
