using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transportation.mode
{
    public class Bond
    {
       public string Email {get ; set ;}
       public string Password {get ; set ;}
       public string Id { get; set;}

        public Bond(string email, string password, string id)
        {
            Email = email;
            Password = password;
            Id = id;
        }
    }
}