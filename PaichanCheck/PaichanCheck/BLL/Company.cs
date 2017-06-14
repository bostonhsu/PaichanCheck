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

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        internal void dispatchPlan(Plan plan)
        {
            dispatchPlanToWorkshops(plan);
        }

        private void dispatchPlanToWorkshops(Plan plan)
        {
            foreach (KeyValuePair<string, Workshop> workshopPair in workshops)
            {
                Workshop aWorkshop = (Workshop) workshopPair.Value;
                aWorkshop.splitPlan(plan);
            }
        }
    }
}
