using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages car expenses.
    /// </summary>
    public class Cars
    {
        public int PropertyTaxAmount { get; set; }
        public int DonegalInsuranceAmount { get; set; }
        public int GasAmount { get; set; }
        public int TollRefillAmount { get; set; }
        public int CarWashAmount { get; set; }


    }
}
