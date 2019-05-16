using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    
    /// <summary>
    /// Manages credit card information.
    /// </summary>
    public class CreditCards
    {
        #region Constructors
        public CreditCards()
        {

            //string[] creditCards = { "Discover", "Visa", "Chase", "Mastercard", "Barclays", "Iphone Barclays" };
     
        }
        #endregion

        public string CardName { get; set; }
        public int CardBalance { get; set; }
        public int MinPaymentDue { get; set; }
        

        /// <summary>
        /// Updates Card Name.
        /// </summary>
        /// <param name="name">Enter new card name.</param>
        /// <returns></returns>
        public string UpdateCardName(string name)
        {
            return name;
        }

    }
}
