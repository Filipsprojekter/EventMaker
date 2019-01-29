using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance = new EventCatalogSingleton();

        public static EventCatalogSingleton Instance
        {
            get { return _instance ?? (_instance = new EventCatalogSingleton());}
        }
        
        public ObservableCollection<Event> Events { get; set; }

        public EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>(); 
        }

        public void Add(Event newEvent)
        {
            Events.Add(newEvent);
        }


        
    }
}