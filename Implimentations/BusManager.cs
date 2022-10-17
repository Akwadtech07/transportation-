using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.interfaces;
using transportation.mode;

namespace transportation.Implimentations
{
    public class BusManager : IBusManager
    {
        public static List<Bus> listOfBus = new List<Bus>();

        public void CreateBus(string fname, string LName, string PhoneNumber, string email, string password)
        {
            throw new NotImplementedException();
        }

        public Bus GetAllBus()
        {
            throw new NotImplementedException();
        }

        public Bus GetBus(string busRegNo)
        {
            throw new NotImplementedException();
        }

        public void UpdateBus(string fName, string LName, string PhoneNumber, string busRegNo)
        {
            throw new NotImplementedException();
        }
    }
}