using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Note
    {
        #region Private fields
        private string _fullName;
        private DateOnly  _birthDate;
        private string _phoneNumber;
        #endregion

        #region Public fields
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public DateOnly BirthDate { get => _birthDate; set => _birthDate = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        #endregion
        public override string ToString()
        {
            return $"Full name is {_fullName}\n"+
                $"Birth date is {_birthDate}\n" +
                $"Phone number is {_phoneNumber}\n"; 
        }
    }
}

