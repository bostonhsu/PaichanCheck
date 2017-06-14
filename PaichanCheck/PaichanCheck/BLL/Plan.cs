using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class Plan
    {
        private Array _timeSpans;
        
        public StandardTime getStandardTime()
        {
            return new StandardTime();
        }

        public Plan copy()
        {
            return new Plan();
        }

        public bool isNotEmpty()
        {
            return false;
        }

        public Task subATimeSpanOfAWorkerAndMakeATask(TimeSpan aTimeSpan)
        {
            return makeATask(subATimeSpanOfAWorker(aTimeSpan));
        }

        private TimeSpan subATimeSpanOfAWorker(TimeSpan aTimeSpan)
        {
            return new TimeSpan();
        }

        private Task makeATask(TimeSpan aTimeSpan)
        {
            return new Task();
        }

        private TimeSpan getTotalTimeSpan()
        {
            TimeSpan result = new TimeSpan();
            for (int i = 0; i < _timeSpans.Length; i++)
            {
                result += (TimeSpan)_timeSpans.GetValue(i);
            }
            return result;
        }
    }
}
