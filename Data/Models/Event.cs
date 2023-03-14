using System;

namespace Mixr.PartyWebApp.Controllers;
{
    public class Event {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Host { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Location { get; set; }


    }
}
