using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace BussinesLogic.Logic
{
    public class ProductoRepository : IProductoRepository
    {
        public Task<IReadOnlyList<Producto>> GetProductoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> GetProductoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }

}
