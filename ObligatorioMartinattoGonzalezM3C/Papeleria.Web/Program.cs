using Papeleria.AccesoDatos.EntityFramework.Repositorios;
using Papeleria.LogicaAplicacion.CasosDeUso.Administradores;
using Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Administrador;
using LogicaNegocio.InterfacesRepositorio;
using AccesoDatos.EntityFramework;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Cliente;
using Papeleria.LogicaAplicacion.CasosDeUso.Clientes;
using Papeleria.LogicaAplicacion.CasosDeUso.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Articulo;
using AccesoDatos.EntityFramework.Repositorios;
using Papeleria.LogicaAplicacion.InterfacesCasosDeUso.Pedido;
using Papeleria.LogicaAplicacion.CasosDeUso.Pedidos;

namespace Papeleria.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuarioEF>();
            builder.Services.AddScoped<IRepositorioConfig, RepositorioConfiguracionEF>();
            builder.Services.AddScoped<IRepositorioCliente, RepositorioClienteEF>();
            builder.Services.AddScoped<IRepositorioArticulo, RepositorioArticuloEF>();
            builder.Services.AddScoped<IRepositorioPedido, RepositorioPedidoEF>();


            builder.Services.AddScoped<ILogin, LoginCU>();
            builder.Services.AddScoped<IEncontrarArticulosOrd, EncontrarArticulosOrdCU>();
            builder.Services.AddScoped<IGetPedidosDesc, GetPedidosDescCU>();
            builder.Services.AddScoped<ICrearAdmin, CrearAdminCU>();
            builder.Services.AddScoped<IEditarAdmin, EditarAdminCU>();
            builder.Services.AddScoped<IFindAdminById, FindAdminByIdCU>();
            builder.Services.AddScoped<IEncontrarAdmins, EncontrarAdminsCU>();
            builder.Services.AddScoped<IBorrarAdmin, BorrarAdminCU>();
            builder.Services.AddScoped<IEncontrarClientes, EncontrarClientesCU>();
            builder.Services.AddScoped<IGetClientesXnombreYapellido, GetClientesXnombreYapellidoCU>();
            builder.Services.AddScoped<IGetClientesXmonto, GetClientesXmontoCU>();
            builder.Services.AddScoped<ICrearArticulo, CrearArticuloCU>();
            builder.Services.AddScoped<IEncontrarArticulos, EncontrarArticulosCU>();
            builder.Services.AddScoped<IEncontrarPedidos, EncontrarPedidosCU>();
            builder.Services.AddScoped<ICrearPedido, CrearPedidoCU>();
            builder.Services.AddScoped<IEncontrarPrecioPedido, EncontrarPrecioPedidoCU>();
            builder.Services.AddScoped<IEncontrarXIdArticulo, FindArticuloByIdCU>();
            builder.Services.AddScoped<IAnularPedido, AnularPedidoCU>();
            builder.Services.AddScoped<IGetPedidosPorFecha, GetPedidosPorFechaCU>();


            builder.Services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromSeconds(5000);
                option.Cookie.HttpOnly = true;
                option.Cookie.IsEssential = true;
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}