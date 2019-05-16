using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages home expenses.
    /// </summary>
    public class Home
    {
        public int MortgagePayment { get; set; }
        public int WaterSewage { get; set; }
        public int LawnCare { get; set; }
        public int Comcast { get; set; }

    }
}
