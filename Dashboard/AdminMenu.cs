using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.Implimentations;
using transportation.Interface;
using transportation.mode;

namespace transportation.Dashboard
{
    public class AdminMenu
    {
        IAdminManager AdminManager = new AdminManager();

        public static List<Admin> listOfAdmins = new List<Admin>();

        public void AdminMenu1()
        {   
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterAdminMenu();
            }
            else if(choice == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        } 
        public void  RegisterAdminMenu()
        {
            Console.WriteLine("Welcome to Admin Manager");

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your PhoneNumber: ");
            string phoneNumber = Console.ReadLine();
            AdminManager.CreateAdmin(email,password,phoneNumber);
            AdminMenu1();
            
        } 

         public void AdminManagerMenu()
        {
            Console.WriteLine("Enter 1 to get all bus\nEnter 2 to get all drivers\n Enter 3 for all tickets\n Enter 4 to get a particular driver\n Enter 5 to get a particular bus, Enter 6 to go back to the previous menu");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                // Bus
            }
            else if(choice == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
                
        }   
        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password  = Console.ReadLine();

            Admin admin = AdminManager.Login(email, password);
            if(admin != null)
            {
                Console.WriteLine("login successful!!!!!!!!!");
                AdminManagerMenu();
            }
            else
            {
                Console.WriteLine("wrong Email or Password");
            }  
    }   } 

   
}