using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using static System.Console;

public class Startup
{
  public void Configure(IApplicationBuilder app)
  {
    //a simple console message
    WriteLine ("Server started on localhost:5001");

    //the simples middleware to log the requests
    app.Use( (ctx,next) => {
        WriteLine($"[{ctx.Request.Method}] {ctx.Request.Path}");
        return next();
      });
    //then run the app (no routing here, same content for each request)
    app.Run(async context =>
    {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync("Hello ASPNET5!");
    });

  }

}
