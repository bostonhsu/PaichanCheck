namespace PaichanCheck.BLL
{
    class TaskMaker
    {
        internal static Task makeTask(Plan plan, Worker worker)
        {
            Task aTask = new Task();

            return aTask;
        }

        private static bool betweenWorkingTime(Plan aPlan, Worker aWorker)
        {
            bool result = false;
            if (aPlan.StartTime >= aWorker.StartTime && aPlan.StartTime <= aWorker.EndTime)
            {
                
            }
            return result;
        }
    }
}
