using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class TicketBooking
    {
        public int TicketQuantity;


        public static Action<int, TicketBooking> AddTickets = (tickets, booking) => booking.TicketQuantity += tickets;

        public static Action<LiveEvent, TicketBooking> UpdateTickets = (userEvent, booking) => userEvent.TicketsAvailable -= booking.TicketQuantity;
    }
}
