using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_App
{
    public class EventService
    {
        private EventRepository eventRepository;
        public EventService(EventRepository repository)
        {
            this.eventRepository = repository;
        }

        public void AddEvent(string date, string eventText,DateTime time)
        {
            eventRepository.Insert(date, eventText, Convert.ToString(time));
        }

        public string CountEvents()
        {
            return eventRepository.Count();
        }
    }
}
