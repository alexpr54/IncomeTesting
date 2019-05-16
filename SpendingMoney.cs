using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages spending money.
    /// </summary>
    public class SpendingMoney
    {
        public int DisposableIncome { get; set; }
        public int Groceries { get; set; }
        public int Restaurants { get; set; }
        public int Dates { get; set; }
        public int UnexpectedThings { get; set; }


    }
}
