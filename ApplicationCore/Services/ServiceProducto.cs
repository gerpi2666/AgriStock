﻿using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceProducto : IServiceProducto
    {
        public Producto GetProductoById(int id)
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetProductoID(id);
        }

        public IEnumerable<Producto> GetProductos()
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetProductos();
        }

        public IEnumerable<Producto> GetProductosByTienda(int id)
        {
            IRepositoryProducto repository = new RepositoryProducto();
            return repository.GetProductosByTienda(id);
        }

    }
}
