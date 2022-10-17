using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transportation.mode;

namespace transportation.Interface
{
    public interface ITicketManager
    {
        public void CreateTicketing(string ticketRefNo, double price);
        public void DeleteTicketing(string ticketRefNo);

        // pay for ticket method (date /driver id payment - wallet)
    
    }
}