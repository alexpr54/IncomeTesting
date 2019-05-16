using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTool.BL
{
    /// <summary>
    /// Manages the users of this application.
    /// </summary>
    public class Users
    {
        #region Ctors
        public Users()
        {

        }

        #endregion

        #region Backing Fields
        
        private string lastName;
        private string firstName;
        private string middleInitial;
        #endregion
        #region Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }
        #endregion
        #region Methods
        public string GetFullName()
        {
            return firstName + " " + middleInitial + ". " + lastName;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(lastName)) isValid = false;

            return isValid;
                
        }
        #endregion 
    }
}
