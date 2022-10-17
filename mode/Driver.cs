using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transportation.mode
{
    public class Driver : Bond
    {
        public string Fname {get; set;}
        public string LName{get; set;}
        public string PhoneNumber {get ; set;}
        public  double Wallet {get; set;}
        
        
        public Driver(string email, string password, string id, string fName, string lName, string phoneNumber, double wallet) : base(email, password, id)
        {
           Fname= fName;
           LName = lName;
           PhoneNumber= phoneNumber;
           Wallet = wallet;
        }
    }
}