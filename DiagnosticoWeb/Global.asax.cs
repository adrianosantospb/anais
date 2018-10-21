using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using DiagnosticoWeb.Model;
using DiagnosticoWeb.ViewModels.Diagnostico;

namespace DiagnosticoWeb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            SolrConfig.SetupMappingAndStartup();

            // Simplificar o mapeamento das propriedades da anamnese de cardiologia e seu view model
            Mapper.CreateMap<AnamneseCardiologia, AnamneseCardiologiaViewModel>();
        }
    }
}