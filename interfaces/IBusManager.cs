using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.mode;

namespace transportation.interfaces
{
    public interface IBusManager
    {
        public void CreateBus(string fname, string LName, string PhoneNumber, string email, string password);
        public void UpdateBus(string fName, string LName, string PhoneNumber, string busRegNo);
        public Bus GetBus(string busRegNo);
        public Bus GetAllBus();
    }
}