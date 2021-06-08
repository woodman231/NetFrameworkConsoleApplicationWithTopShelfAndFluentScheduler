using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace NetFrameworkTopShelfFluentSchedulerExample
{
    public class ExampleService
    {
        public ExampleService(ServiceConfig serviceConfig)
        {
            var jobRegistry = new JobRegistry(serviceConfig);

            JobManager.Initialize(jobRegistry);
        }

        public bool Start()
        {
            JobManager.Start();
            return true;
        }

        public bool Stop()
        {
            JobManager.Stop();
            return true;
        }
    }
}
