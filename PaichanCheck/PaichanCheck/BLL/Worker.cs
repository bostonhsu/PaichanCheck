using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class Worker
    {
        private Dictionary<string, Task> tasks;
        private Employee employee;
        private TimeSpan workingTimeSpan;

        public Worker()
        {
            tasks = new Dictionary<string, Task>();
        }

        internal void eatPlan(Plan plan)
        {
            Task aTask = new Task();
            aTask = plan.subATimeSpanOfAWorkerAndMakeATask(workingTimeSpan);
            try
            {
                tasks.Add(getUniqueIdOfTask(), aTask);
            }
            catch (ArgumentException)
            {
                
            }
        }

        private string getUniqueIdOfTask()
        {
            throw new NotImplementedException();
        }
    }
}
