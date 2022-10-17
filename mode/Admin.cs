using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transportation.mode
{
    public class Admin : Bond
    {
       
        public string PhoneNumber {get; set;}
        
        public Admin(string email,string password, string id, string phoneNumber) : base(email, password ,id)
        {
            
            PhoneNumber = phoneNumber;
        }
    }
}