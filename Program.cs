using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace twofifteen_api_asp_net_core
{
  public class Program
    {
    public static void Main(string[] args)
      { BuildWebHost(args).Run(); }

      public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .Build();
    }
  }
