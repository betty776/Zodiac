using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ZodiacSign
    {
        public ZodiacSign(string sign, string startMonth, string startDay,
            string finishMonth, string finishDay)
        {
            this.zodiacSign = sign;
            this.startMonth = startMonth;
            this.startDay = startDay;
            this.endMonth = finishMonth;
            this.endDay = finishDay;
        }

        public string Sign
        {
            get
            {
                return zodiacSign;
            }
        }

        public string StartMonth
        {
            get
            {
                return startMonth;
            }
        }

        public string StartDay
        {
            get
            {
                return startDay;
            }
        }

        public string EndMonth
        {
            get
            {
                return endMonth;
            }
        }

        public string EndDay
        {
            get
            {
                return endDay;
            }
        }

        private string zodiacSign;
        private string startMonth;
        private string startDay;
        private string endMonth;
        private string endDay;
    }
}
