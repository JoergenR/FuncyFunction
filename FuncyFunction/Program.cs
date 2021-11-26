using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace FuncyFunction
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            host.Run();
        }
    }
}