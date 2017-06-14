using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaichanCheck.BLL
{
    class DatetimeSpan
    {
        private DateTime _startDateTime;
        private DateTime _endDateTime;

        public DateTime StartDateTime
        {
            get
            {
                return _startDateTime;
            }

            set
            {
                _startDateTime = value;
            }
        }

        public DateTime EndDateTime
        {
            get
            {
                return _endDateTime;
            }

            set
            {
                _endDateTime = value;
            }
        }
    }
}
