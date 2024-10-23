﻿using Papeleria.LogicaAplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Movimiento
{
    public interface IGetMovsXFecha
    {
        public IEnumerable<FechaDTO> GetMovsXFecha();
    }
}
