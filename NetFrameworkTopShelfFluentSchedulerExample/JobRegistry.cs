using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace NetFrameworkTopShelfFluentSchedulerExample
{
    public class JobRegistry : Registry
    {
        public JobRegistry(ServiceConfig serviceConfig)
        {
            NonReentrantAsDefault();

            if(serviceConfig.RunNow)
            {
                Schedule<ExampleJob>().ToRunNow().AndEvery(1).Days().At(serviceConfig.RunHour, serviceConfig.RunMinute);
            }
            else
            {
                Schedule<ExampleJob>().ToRunEvery(1).Days().At(serviceConfig.RunHour, serviceConfig.RunMinute);
            }
        }
    }
}
