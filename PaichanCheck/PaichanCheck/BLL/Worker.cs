using System;
using System.Collections.Generic;

namespace PaichanCheck.BLL
{
    class Worker
    {
        private Dictionary<string, Task> tasks;
        private Employee employee;
        private DatetimeSpan workingTimeSpan;

        internal void eatPlan(Plan plan)
        {
            tasks.Add(getUniqueIdOfTask(), TaskMaker.makeTask(plan, this));
        }

        private string getUniqueIdOfTask()
        {
            throw new NotImplementedException();
        }
    }
}
