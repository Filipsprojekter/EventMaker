using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Events.Annotations;
using Events.Model;

namespace Events.ViewModel
{
    class EventViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Event> _events;
        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public EventViewModel()
        {
            _events = new ObservableCollection<Event>();
            EventCatalogSingleton = EventCatalogSingleton.Instance;

            EventCategories = new ObservableCollection<EventCategory>();
            EventCategories.Add(new EventCategory("Wedding", new Uri("ms-appx:///Assets/background.jpg")));
            EventCategories.Add(new EventCategory("Birthday", new Uri("ms-appx:///Assets/background.jpg")));

        }

        public string EventCategory { get; set; }
        public Uri Uri { get; set; }

        public ObservableCollection<EventCategory> EventCategories { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
