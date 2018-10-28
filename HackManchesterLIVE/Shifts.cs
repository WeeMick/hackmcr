using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackManchesterLIVE
{
    class Shifts
    {
        String startTime;
        String finishTime;
        String startDate;
        String finishDate;

        public Shifts(String startTime, String finishTime, String startDate, String finishDate)
        {
            this.startTime = startTime;
            this.finishTime = finishTime;
            this.startDate = startDate;
            this.finishDate = finishDate;
        }

        public String getStartTime() {
            return startTime;
        }

        public String getFinishTime() {
            return finishTime;
        }

        public String getStartDate() {
            return startDate;
        }

        public String getFinishDate() {
            return finishDate;
        }
    }
}
