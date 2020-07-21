using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SJB.TwoFifteen.Context;

namespace SJB.TwoFifteen
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
      { Configuration = configuration; }

    // This method is called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddDbContext<TwoFifteenContext> (options => options.UseSqlServer(Configuration.GetConnectionString("TwoFifteenConnection")));
    }

    // This method is  called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

      app.UseRouting();
      app.UseHttpsRedirection();
      app.UseEndpoints(endpoints => endpoints.MapControllers());
      app.UseFileServer(enableDirectoryBrowsing: false);
    }
  };
};
