using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.Interface;
using transportation.mode;

namespace transportation.Implimentations
{
    
    public class AdminManager : IAdminManager
    {
       public static List<Admin> listOfAdmins = new List<Admin>();

        public void CreateAdmin(string email, string password, string phoneNumber)
        {
            Random rand = new Random();
            string id = "AKD/AD" + rand.Next(001, 100).ToString();
            Admin Adm = new Admin(email, password, id, phoneNumber);
            listOfAdmins.Add(Adm);
            Console.WriteLine($"Congratulation {Adm.Email}, your staff identity number is {Adm.Id}");
        }



        public Admin GetAdmin(string email)
        {
            throw new NotImplementedException();
        }

        
        public Admin Login(string email, string password)
        {
           
            foreach (var item in listOfAdmins)
            {
                if (item.Email == email && item.Password == password)
                {
                    
                    return item;
                }
            }
            return null;
        }

        public void UpdateAmin(string email, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}