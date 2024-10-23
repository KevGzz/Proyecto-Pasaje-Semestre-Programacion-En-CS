﻿using LogicaNegocio.InterfacesRepositorio;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioMovimiento : IRepositorio<Movimiento>
    {
        IEnumerable<Movimiento> GetMovs(int pag, int size);
        IEnumerable<Movimiento> GetByArtyTipo(int articuloId, int tipoMovId, int pag, int size);
    }
}
