﻿using Papeleria.LogicaAplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Articulo
{
    public interface ICrearArticulo
    {
        void CrearArticulo(ArticuloDTO aCrear);
    }
}
