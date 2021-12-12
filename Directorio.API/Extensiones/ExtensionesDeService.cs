using Directorio.AppService.Servicios.Interfaz;
using Directorio.AppService.Servicios.Implementacion;
using Directorio.Data.Repositorio.Implementacion;
using Directorio.Data.Repositorio.Interfaz;
using Microsoft.Extensions.DependencyInjection;

namespace Directorio.API.Extensiones
{
    public static class ExtensionesDeService
    {
        public static void InyeccionesDeDependencia(this IServiceCollection services)
        {
            //Inyeccion del repositorio
            services.AddScoped(typeof(IDirectorioRepositorio), typeof(DirectorioRepositorio));

            //Inyeccion del Servicio
            services.AddScoped(typeof(IDirectorioServicio), typeof(DirectorioService));
        }
    }
}
