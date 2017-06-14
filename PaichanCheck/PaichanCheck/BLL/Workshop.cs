using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class Workshop
    {
        private Dictionary<String, Worker> workers;

        internal void dispatchPlan(Plan plan)
        {
            dispatchPlanToWorker(plan);
        }

        private void dispatchPlanToWorker(Plan plan)
        {
            eatPlanByWorkers(plan.copy());
        }

        private void eatPlanByWorkers(Plan aTempPlan)
        {
            while (aTempPlan.isNotEmpty())
            {
                foreach (KeyValuePair<string, Worker> workerPair in workers)
                {
                    Worker aWorker = (Worker) workerPair.Value;
                    aWorker.eatPlan(aTempPlan);
                    if (!aTempPlan.isNotEmpty())
                    {
                        break;
                    }
                }
            }
        }
    }
}
