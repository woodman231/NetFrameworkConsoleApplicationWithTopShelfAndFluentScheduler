using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace NetFrameworkTopShelfFluentSchedulerExample
{
    class ExampleJob : IJob
    {
        public void Execute()
        {
            Console.WriteLine("Example Job Executed...");

            // What you really need the service to do will start here...
        }
    }
}
