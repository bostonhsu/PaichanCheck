using System;

namespace PaichanCheck.BLL
{
    class Plan : ICloneable
    {
        private DateTime _startDateTime;
        private int _totalMinutes;

        public object Clone()
        {
            Plan plan = new Plan();
            plan._startDateTime = _startDateTime;
            plan._totalMinutes = _totalMinutes;
            return plan;
        }
        
        public bool isNotEmpty()
        {
            return !isEmpty();
        }

        private bool isEmpty()
        {
            return _totalMinutes <= 0;
        }
    }
}
