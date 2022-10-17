using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transportation.mode
{
    public class Ticketing : Bond
    {
        public string TicketRefNo {get ; set;}
        public double Price {get; set;}
        
        public Ticketing(string email, string password, string id , string ticketRefNo, double price) : base(email, password, id)
        {
           TicketRefNo = ticketRefNo;
            Price = Price;
             
        }

    }
}