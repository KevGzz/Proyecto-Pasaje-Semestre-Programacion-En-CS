﻿using AccesoDatos.EntityFramework;
using LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EntityFramework.Repositorios
{
    public class RepositorioTipoMovimientoEF : IRepositorioTipoMovimiento
    {
        private PapeleriaContext _context;
        public RepositorioTipoMovimientoEF()
        {
            this._context = new PapeleriaContext();
        }

        public bool Add(TipoMovimiento aAgregar)
        {
            try
            {
                aAgregar.IsValid();
                this._context.TipoMovimientos.Add(aAgregar);
                this._context.SaveChanges();
                return true;
            }
            catch (TMovException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TipoMovimiento> FindAll()
        {
            return this._context.TipoMovimientos;
        }

        public TipoMovimiento FindByID(int id)
        {
            return this._context.TipoMovimientos.Where(t => t.Id == id).FirstOrDefault();
        }

        public bool Remove(int id)
        {
            try
            {
                
                TipoMovimiento aBorrar = FindByID(id);
                IEnumerable<Movimiento> movimientos = this._context.Movimientos.Where(m => m.TipoMovimiento.Id == aBorrar.Id).ToList();
                if (movimientos.Count() == 0)
                {
                    this._context.TipoMovimientos.Remove(aBorrar);
                    this._context.SaveChanges();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TipoMovimiento aModificar)
        {
            try
            {
                IEnumerable<Movimiento> movimientos = this._context.Movimientos.Where(m => m.TipoMovimiento.Id == aModificar.Id).ToList();
                if (movimientos.Count() == 0)
                {
                    this._context.TipoMovimientos.Update(aModificar);
                    this._context.SaveChanges();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
