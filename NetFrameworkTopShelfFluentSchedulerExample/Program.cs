using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Topshelf;

namespace NetFrameworkTopShelfFluentSchedulerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureService();
        }

        static void ConfigureService()
        {
            ServiceConfig serviceConfig = GetServiceConfig();

            HostFactory.Run(serviceOptions =>
            {
                serviceOptions.Service<ExampleService>(serviceInstance =>
                {
                    serviceInstance.ConstructUsing(() => new ExampleService(serviceConfig));
                    serviceInstance.WhenStarted(execute => execute.Start());
                    serviceInstance.WhenStopped(execute => execute.Stop());
                });

                serviceOptions.RunAsNetworkService();

                serviceOptions.SetServiceName(serviceConfig.ServiceName);
                serviceOptions.SetDisplayName(serviceConfig.ServiceDisplayName);
                serviceOptions.SetDescription(serviceConfig.ServiceDescription);

                serviceOptions.StartAutomatically();
            });
        }

        static ServiceConfig GetServiceConfig()
        {            
            return new ServiceConfig
            {
                ServiceName = ConfigurationManager.AppSettings["ServiceName"],
                ServiceDisplayName = ConfigurationManager.AppSettings["ServiceDisplayName"],
                ServiceDescription = ConfigurationManager.AppSettings["ServiceDescription"],
                RunNow = Convert.ToBoolean(ConfigurationManager.AppSettings["RunNow"]),
                RunHour = Convert.ToInt32(ConfigurationManager.AppSettings["RunHour"]),
                RunMinute = Convert.ToInt32(ConfigurationManager.AppSettings["RunMinute"])
            };
        }
    }
}
