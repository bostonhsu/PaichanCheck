using System;
using System.Collections.Generic;

namespace PaichanCheck.BLL
{
    class Team
    {
        private Dictionary<string, Worker> workers;

        public bool isHalf()
        {
            bool result = false;
            foreach (KeyValuePair<string, Worker> workerPair in workers)
            {
                Worker aWorker = (Worker) workerPair.Value;
                if (aWorker.isHalf())
                {
                    result = true;

                }
            }
            return result;
        }

        internal void splitPlan(Plan aPlan)
        {
            splitPlanToWorkers(aPlan);
        }

        private void splitPlanToWorkers(Plan aPlan)
        {
            while (aPlan.isNotEmpty())
            {
                foreach (KeyValuePair<string, Worker> workerPair in workers)
                {
                    Worker aWorker = (Worker) workerPair.Value;
                    aWorker.eatPlan(aPlan);
                    if (!aPlan.isNotEmpty())
                    {
                        break;
                    }
                }

            }
        }
    }
}
