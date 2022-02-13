using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Data
{
   public class MarketDbContextData
    {

        public static async Task CargarDataAsync(MarketDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Marca.Any()) {
                    var marcaData = File.ReadAllText("../BussinesLogic/CargarData/marca.json");
                    var marcas = JsonSerializer.Deserialize<List<Marca>>(marcaData);

                    foreach(var m in marcas)
                    {
                        context.Marca.Add(m);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Categoria.Any())
                {
                    var categoriaData = File.ReadAllText("../BussinesLogic/CargarData/categoria.json");
                    var categorias = JsonSerializer.Deserialize<List<Categoria>>(categoriaData);

                    foreach (var c in categorias)
                    {
                        context.Categoria.Add(c);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Producto.Any())
                {
                    var productoData = File.ReadAllText("../BussinesLogic/CargarData/producto.json");
                    var productos = JsonSerializer.Deserialize<List<Producto>>(productoData);

                    foreach (var p in productos)
                    {
                        context.Producto.Add(p);
                    }

                    await context.SaveChangesAsync();
                }


            } catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<MarketDbContextData>();
                logger.LogError(e.Message);
            }
        }
    }
}
