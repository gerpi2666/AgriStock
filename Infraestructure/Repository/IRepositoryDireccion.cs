﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
   public interface IRepositoryDireccion
    {
        IEnumerable<Direccion> GetDirecciones();
        Direccion GetDireccionById(int id);
    }
}
