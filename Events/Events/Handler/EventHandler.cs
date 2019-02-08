using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Converter;
using Events.Model;
using Events.ViewModel;

namespace Events.Handler
{
    class EventHandler
    {
        public EventViewModel EventViewModel { get; set; }

        public EventHandler(EventViewModel eventViewModel)
        {
            EventViewModel = eventViewModel;
        }

        public void CreateEvent()
        {
            Event newEvent = new Event(EventViewModel.Id, 
                                        EventViewModel.Name, 
                                        EventViewModel.Description, 
                                        EventViewModel.Place, 
                                        DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel.Date, EventViewModel.Time));
            EventViewModel.EventCatalogSingleton.Add(newEvent);

        }

}
