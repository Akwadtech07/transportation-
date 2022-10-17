using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.Implimentations;
using transportation.mode;

namespace transportation.Dashboard
{
    public class mainMenu 
    {

         public static List<Admin> listOfAdmins = new List<Admin>();   
        public void MainMenu()
        {
            
            Console.WriteLine("Welcome to Transportation Management System \nHow can we help you");

            Console.WriteLine("Enter 1 as Admin\nEnter 2 as Thicketer\nEnter 3 as Passanger");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                AdminMenu am = new AdminMenu();
                am.AdminMenu1(); 
            }

            else if(opt == 2)
            {
                TicketingMenu ticket = new TicketingMenu();
                ticket.TicketMenu();
            }
            else if (opt == 3)
            {
                 
                BusManager bus = new BusManager();
                // bus.
            }
            
        }
    }
}