using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class Workshop
    {
        private Dictionary<string, Team> teams;

        internal void splitPlan(Plan plan)
        {
            splitPlanToTeams((Plan)plan.Clone());
        }

        private void splitPlanToTeams(Plan aPlan)
        {
            while (aPlan.isNotEmpty())
            {
                foreach (KeyValuePair<string, Team> teamPair in teams)
                {
                    Team aTeam = teamPair.Value;
                    aTeam.splitPlan(aPlan);
                    if (!aPlan.isNotEmpty())
                    {
                        break;
                    }
                }

            }
        }
    }
}
