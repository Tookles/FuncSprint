using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class LiveEvent
    {
        public static long ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public int TicketsAvailable { get; set; }

        public LiveEvent(string name, DateTime date, string venue, int ticketsAvailable)
        {
            Name = name;
            Date = date;
            Venue = venue;
            TicketsAvailable = ticketsAvailable;
            ID = ID++;
        }
    }
}
