using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BoosterAppForNepal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UnicefPage : Page
    {
        public UnicefPage()
        {
            this.InitializeComponent();
            events.DataContext = newEvent;
            
            newEvent.Add(new newEvents("IPV", "Polio", new DateTime(2014,06,16),"Itahari","New immunization camp"));
            newEvent.Add(new newEvents("IPV", "Polio", new DateTime(2014, 06, 16), "Itahari", "New immunization camp"));
            newEvent.Add(new newEvents("IPV", "Polio", new DateTime(2014, 06, 16), "Itahari", "New immunization camp"));
            newEvent.Add(new newEvents("IPV", "Polio", new DateTime(2014, 06, 16), "Itahari", "New immunization camp"));
        }


        public class newEvents
        {
            public newEvents() { }

            public newEvents(string vaccine, string disease, DateTime date, string location, string description)
            {
                Vaccine = vaccine;
                Disease = disease;
                Date = date;
                Location = location;
                Description = description;
            }
            public string Vaccine { get; set; }
            public string Disease { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }
            public string Description {get; set;}
            

            public override string ToString()
            {
                return Vaccine + " on " + Date.ToString("d") + " at " + Location;
            }
        }
        public ObservableCollection<newEvents> newEvent = new ObservableCollection<newEvents>();

        private void addEvent_click(object sender, RoutedEventArgs e)
        {
            newEvent.Add(new newEvents(vaccineName.Text, diseaseName.Text, new DateTime(2014, 06, 16), location.Text, description.Text));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
