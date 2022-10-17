using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.mode;

namespace transportation.interfaces
{
    public interface IDriver
    {
        public void CreateDriver(string fname, string LName, string PhoneNumber, string email, string password);
        public void UpdateDriver(string fName, string LName, string PhoneNumber);
        public Driver GetDriver(string email);
        // public Driver GetAllDrivers(); list of drivers
        public  bool  MakePayment(double wallet);
        //delete driver
        
        public Driver Login(string email, string password);
    }
}