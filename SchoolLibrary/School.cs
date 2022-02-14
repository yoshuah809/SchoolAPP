using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class School
    { 
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //Requires address starts with @ symbol
            get { return _twitterAddress; }

            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }else{
                    throw new Exception("Twitter Address musb beging with @ Symbol");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-5555";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
           Name = SchoolName;
           PhoneNumber = SchoolPhoneNumber; 
        }
    }
      
}
