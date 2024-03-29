using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
// using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TwoFifteen.Application.Context;

public class Startup
{
  public IConfiguration Configuration { get; }

  public Startup(IConfiguration configuration)
  { Configuration = configuration; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllers();
    // services.AddDbContext<TwoFifteenContext>(options =>
    //   options.UseSqlServer(Configuration.GetConnectionString("TwoFifteenConnection"))
    // );
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseEndpoints(endpoints => endpoints.MapControllers());
    // app.MapGraphQL("/graphql");
    app.UseFileServer(enableDirectoryBrowsing: false);
  }
}
