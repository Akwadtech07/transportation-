using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.mode;

namespace transportation.Interface
{
    public interface IAdminManager 
    {
        public void CreateAdmin(string email, string password, string phoneNumber);
        public void UpdateAmin(string email, string phoneNumber);
        public Admin GetAdmin(string email);
       
        public Admin Login(string email, string password);
        
    }
}