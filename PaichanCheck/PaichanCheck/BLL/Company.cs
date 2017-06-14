using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class Company
    {
        private Dictionary<String, Workshop> workshops;

        internal void dispatchPlan(Plan plan)
        {
            dispatchPlanToWorkshop(plan);
        }

        private void dispatchPlanToWorkshop(Plan plan)
        {
            foreach (KeyValuePair<string, Workshop> workshopPair in workshops)
            {
                Workshop aWorkshop = (Workshop) workshopPair.Value;
                aWorkshop.dispatchPlan(plan);
            }
        }
    }
}
