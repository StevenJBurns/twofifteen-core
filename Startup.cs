using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SJB.TwoFifteen.API.DataAccessLayer;

namespace SJB.TwoFifteen.API
{
  public class Startup
    {
    public Startup(IConfiguration configuration)
      { Configuration = configuration; }

    public IConfiguration Configuration { get; }
    
    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
      {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      services.AddDbContext<TwoFifteenContext> (options => options.UseSqlServer(Configuration.GetConnectionString("TwoFifteenConnection")));
      }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
      if (env.IsDevelopment())
        {
          app.UseDeveloperExceptionPage();
        }
      else
        {
          app.UseExceptionHandler("/Error");
          app.UseHsts();
        }
      
      app.UseMvc();
      app.UseHttpsRedirection();
      app.UseFileServer(enableDirectoryBrowsing: false);
      }
    }
}
