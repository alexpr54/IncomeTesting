using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages all income to Rosado's household.
    /// </summary>
    public class Income
    {
        //Backing fields:
        public int LsgIncome { get; set; }
        public int JulianaDeposit { get; set; }
        public int RolloverAmount { get; set; }
        public int UnexpectedIncome { get; set; }
        public int FamilyGift { get; set; }
       

        //Methods:
        /// <summary>
        /// Adds income every payperiod.
        /// </summary>
        /// <returns></returns>
        public int AddIncomes()
        {
            return LsgIncome + JulianaDeposit + RolloverAmount + UnexpectedIncome + FamilyGift;
        }

        /// <summary>
        /// Updates current balance.
        /// </summary>
        /// <param name="CurrentBalace">Current Checking Account Balance.</param>
        /// <returns>Return updated income amount.</returns>
        public int UpdateBalanceAmount(int CurrentBalace)
        {

            var updatedAmount = CurrentBalace + LsgIncome + JulianaDeposit + RolloverAmount + FamilyGift + UnexpectedIncome;
            return updatedAmount;
        }
    }
}
