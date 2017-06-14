using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class AutoDispatcher
    {
        public static void dispatchPlanToCompany(Plan plan, Company company)
        {
            company.dispatchPlan(plan);
        }
    }
}
