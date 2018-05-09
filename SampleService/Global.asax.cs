using AutoMapper;
using SampleService.WebApi.Notes;
using System.Web.Http;

namespace SampleService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(cfg =>
            {
                NotesController.SetupMapper(cfg);
            });
        }
    }
}
