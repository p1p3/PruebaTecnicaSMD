using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using PruebaTecnica.Core.UnitOfWork;
using Data.EntityFramework.UnitOfWork;
using PruebaTecnica.Core.Servicios.Interfaces;
using PruebaTecnica.Core.Servicios.Implementaciones;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            string connectionString = "DefaultConnection";

            var containerTemp = new UnityContainer();

            InjectionConstructor injectionConstructor = new InjectionConstructor(connectionString);
            containerTemp.RegisterType<IUnitOfWork, UnitOfWork>(injectionConstructor);
            IUnitOfWork UOW = containerTemp.Resolve<IUnitOfWork>();

            injectionConstructor = new InjectionConstructor(UOW);
            container.RegisterType<IProductoServicio, ProductoService>(injectionConstructor);
            container.RegisterType<ICatalogoServicio, CatalogoServicio>(injectionConstructor);


            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}