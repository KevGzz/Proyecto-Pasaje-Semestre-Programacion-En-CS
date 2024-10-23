﻿using Microsoft.AspNetCore.Mvc;
using Papeleria.LogicaAplicacion.DTOs;
using Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Cliente;

namespace Papeleria.Web.Controllers
{
    public class ClientesController : Controller
    {

        private IEncontrarClientes _encontrarClientes;
        private IGetClientesXnombreYapellido _xnombreYapellido;
        private IGetClientesXmonto _xMonto;

        public ClientesController(IEncontrarClientes encontrarClientes, IGetClientesXnombreYapellido xnombreYapellido, IGetClientesXmonto xMonto)
        {
            _encontrarClientes = encontrarClientes;
            _xnombreYapellido = xnombreYapellido;
            _xMonto = xMonto;
        }



        // GET: ClientesController
        public ActionResult Index(string mensaje, string filtro)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("usuario")))
            {
                return RedirectToAction("Index", "Login", new { mensaje = "Por favor inicie sesion" });
            }
            IEnumerable<ClienteDTO> toShow = new List<ClienteDTO>();
            ViewBag.Mensaje = mensaje;
            ViewBag.Clientes = this._encontrarClientes.FindAllClientes();

            if (string.IsNullOrEmpty(filtro))
            {
                toShow = _encontrarClientes.FindAllClientes();
            }
            if (filtro == "PorNombre")
            {
                string nombreCliente = (string)TempData["NombreCliente"];
                toShow = this._xnombreYapellido.GetClientesXnombreYapellido(nombreCliente);
            }
            if(filtro == "PorMonto")
            {
                double monto;
                if(double.TryParse(TempData["Monto"].ToString(), out monto)) toShow = this._xMonto.GetClientesXmonto(monto);
            }
            return View(toShow);
        }

        [HttpPost]
        public ActionResult FiltrarPorNombre (string nombreCliente)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("usuario")))
            {
                return RedirectToAction("Index", "Login", new { mensaje = "Por favor inicie sesion" });
            }
            if (nombreCliente == null)
            {
                return RedirectToAction("Index");
            }
            TempData["NombreCliente"] = nombreCliente;
            return RedirectToAction("Index", new { filtro = "PorNombre" });
        }

        [HttpPost]
        public ActionResult FiltrarPorMonto (double monto)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("usuario")))
            {
                return RedirectToAction("Index", "Login", new { mensaje = "Por favor inicie sesion" });
            }
            if (monto <= 0)
            {
                return RedirectToAction("Index", new { mensaje = "Monto invalido." });
            }
            TempData["Monto"] = monto.ToString();
            return RedirectToAction("Index", new { filtro = "PorMonto" });
        }

    }
}
