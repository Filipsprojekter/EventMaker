using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Events.Annotations;
using Events.Model;
using Events.View;

namespace Events.ViewModel
{
    class EventViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Event> _events;
        public EventCatalogSingleton EventCatalogSingleton { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }

        public EventViewModel()
        {
            _events = new ObservableCollection<Event>();
            EventCatalogSingleton = EventCatalogSingleton.Instance;

            DateTime dt = System.DateTime.Now;

            Date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            EventCategories = new ObservableCollection<EventCategory>();
            EventCategories.Add(new EventCategory("Wedding", new Uri("ms-appx:///Assets/wedding.jpg")));
            EventCategories.Add(new EventCategory("Birthday", new Uri("ms-appx:///Assets/birthday.jpg")));
            EventCategories.Add(new EventCategory("Thanksgiving", new Uri("ms-appx:///Assets/Thanksgiving.jpg")));
            EventCategories.Add(new EventCategory("Halloween", new Uri("ms-appx:///Assets/halloween.jpg")));
            EventCategories.Add(new EventCategory("Valentines Day", new Uri("ms-appx:///Assets/valentinesDay.png")));
            EventCategories.Add(new EventCategory("New Years Eve", new Uri("ms-appx:///Assets/NewYearsEve.jpg")));
            EventCategories.Add(new EventCategory("Bachelorette Party", new Uri("ms-appx:///Assets/bachelorette.jpg")));
            EventCategories.Add(new EventCategory("Confirmation", new Uri("ms-appx:///Assets/Confirmation.png")));

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


        private void CheckEvent()
        {
            if ()
            {
                ((Frame)Window.Current.Content).Navigate(typeof(Confirmation));
            }
        }
    }
}
