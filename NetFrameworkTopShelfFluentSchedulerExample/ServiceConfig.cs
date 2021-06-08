using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkTopShelfFluentSchedulerExample
{
    public class ServiceConfig
    {
        public string ServiceName { get; set; }
        public string ServiceDisplayName { get; set; }
        public string ServiceDescription { get; set; }
        public bool RunNow { get; set; }
        public int RunHour { get; set; }
        public int RunMinute { get; set; }
    }
}
