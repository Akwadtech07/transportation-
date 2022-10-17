using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transportation.mode
{
    public class Bus: Driver
    {

        public string BusRegNo{get; set;}
        
        public Bus(string email, string password, string id ,string fName, string lName, string phoneNumber, double wallet, string busRegNo) : base(email, password, id, fName, lName, phoneNumber, wallet)
        {
           
           BusRegNo= busRegNo;
             
        }
    }
}