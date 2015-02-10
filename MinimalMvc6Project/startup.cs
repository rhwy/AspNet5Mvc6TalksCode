//https://github.com/rhwy/AspNet5Mvc6TalksCode
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Http;

public class Startup
{
        public void ConfigureServices(IServiceCollection services)
        {
                services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
          //first test by uncommenting this
          //app.UseWelcomePage();
          app.UseMvc(routes => {
              routes.MapRoute(name:"default",
              template:"{controller=home}/{action=index}");
          });
        }
}
