using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages pay periods.
    /// </summary>
    public class PayPeriods
    {
        public PayPeriods()
        {
            var payPeriods = new string[25];
        }

        public int PayPeriodNumber { get; set; }
        public DateTimeOffset PayDayDate { get; set; }

    }
}
