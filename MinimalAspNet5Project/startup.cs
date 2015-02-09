using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using static System.Console;

public class Startup
{
  public void Configure(IApplicationBuilder app)
  {

    WriteLine ("Server started on localhost:5001");

    app.Use( (ctx,next) => {
        WriteLine($"[{ctx.Request.Method}] {ctx.Request.Path}");
        return next();
      });
      
    app.Run(async context =>
    {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync("Hello MVC6!");
    });

  }

}
