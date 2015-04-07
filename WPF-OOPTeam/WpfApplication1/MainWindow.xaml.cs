using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using EventScheduler.Data;
using EventScheduler.Data.Staff;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public List<Event> eventsList;
        
        public MainWindow()
        {
            InitializeComponent();
            /*var colllect = new List<Admin>
                {
                        
                        new Admin { Event = 1, Name = "Nomer1"},
                        new Admin { Event = 2, Name = "Nomer2"},
                        new Admin { Event = 3, Name = "Nomer3"},
                        new Admin { Event = 4, Name = "Nomer4"},
                        new Admin { Event = 5, Name = "Nomer5"},
                        new Admin { Event = 6, Name = "Nomer6"},
                };

            
            MyDataGrid.ItemsSource = colllect;*/

            var eventOne = new Event();
            var eventTwo = new Event();
            var eventThree = new Event();
            var eventFour = new Event();
            var eventFive = new Event();

            #region enventMakeing
            eventOne.Budget = 1205.00m;
            eventOne.DateTime = DateTime.Parse("01.12.2015 20:00:00");
            eventOne.EventStaff = new List < EventStaff>(){ new DJ("MC Grozen", eventOne, 200),new Cook("Bai Ivan",eventOne,50,true)};
            eventOne.Location = new Location(new Coordinates(40.25m, 10.12m),"Limoncheto");
            eventOne.MeetingPoint = "Pazara";
            eventOne.Organizer = new Organizer("Ivailo", "Kenov", EventScheduler.Data.Enumerations.Gender.Male, eventOne, "i_k@abv.bg", "+359 888 888 888", 1300);
            eventOne.ParticipantsList = new List<Participant>();
            for (int i = 0; i < 20; i++)
            {
                eventOne.ParticipantsList.Add(
                    new Participant("Participant" + (i + 1).ToString(), "LastName" + (i + 1).ToString(), eventOne,
                        "p" + (i + 1).ToString() + "@gmail.com", "0888 888 8" + (i + 1).ToString(), 25));
            }
            eventOne.Title = "Naj ludoto party ever";

            eventTwo.Budget = 6500.00m;
            eventTwo.DateTime = DateTime.Parse("08.12.2015 22:00:00");
            eventTwo.EventStaff = new List<EventStaff>() { new DJ("MC Typ", eventTwo, 200),new Singer("Analiq",eventTwo,5000,true) , new Cook("Bai Ivan", eventTwo, 50, true) };
            eventTwo.Location = new Location(new Coordinates(80.25m, 120.12m), "Riblja Corba");
            eventTwo.MeetingPoint = "NDK";
            eventTwo.Organizer = new Organizer("Doncho", "Minkov", EventScheduler.Data.Enumerations.Gender.Male, eventTwo, "D_M@abv.bg", "+359 888 888 666", 6500);
            eventTwo.ParticipantsList = new List<Participant>();
            for (int i = 0; i < 20; i++)
            {
                eventTwo.ParticipantsList.Add(
                    new Participant("Participant" + (i + 21).ToString(), "LastName" + (i + 21).ToString(), eventTwo,
                        "p" + (i + 21).ToString() + "@gmail.com", "0888 888 8" + (i + 21).ToString(), 25));
            }
            eventTwo.Title = "Narko party";

            eventThree.Budget = 26500.00m;
            eventThree.DateTime = DateTime.Parse("31.12.2015 22:00:00");
            eventThree.EventStaff = new List<EventStaff>() {  new Singer("Jochan Strauss JR", eventThree, 25000, true)};
            eventThree.Location = new Location(new Coordinates(54.25m, 50.12m), "NDK");
            eventThree.MeetingPoint = "NDK";
            eventThree.Organizer = new Organizer("Evlogi", "Georgiev", EventScheduler.Data.Enumerations.Gender.Male, eventThree, "EG@abv.bg", "+359 888 888 686", 26500);
            eventThree.ParticipantsList = new List<Participant>();
            for (int i = 0; i < 20; i++)
            {
                eventThree.ParticipantsList.Add(
                    new Participant("Participant" + (i + 321).ToString(), "LastName" + (i + 321).ToString(), eventThree,
                        "p" + (i + 321).ToString() + "@gmail.com", "0888 888 8" + (i + 321).ToString(), 125));
            }
            eventThree.Title = "Forever Classics";

            eventFour.Budget = 0.00m;
            eventFour.DateTime = DateTime.Now.AddDays(1);
            eventFour.Location = new Location(new Coordinates(4.25m, 0.12m), "U vas");
            eventFour.MeetingPoint = "Mr. Popa";
            eventFour.Organizer = new Organizer("Nikolai", "Kostov", EventScheduler.Data.Enumerations.Gender.Male, eventFour, "nikiIT@abv.bg", "+359 888 888 000", 2.5m);
            eventFour.ParticipantsList = new List<Participant>();
            for (int i = 0; i < 20; i++)
            {
                eventFour.ParticipantsList.Add(
                    new Participant("Participant" + (i + 4321).ToString(), "LastName" + (i + 4321).ToString(), eventFour,
                        "p" + (i + 4321).ToString() + "@gmail.com", "0888 888 8" + (i + 4321).ToString(), 0));
            }
            eventFour.Title = "Pijama party";
            #endregion
             eventsList = new List<Event> { eventOne, eventTwo, eventThree, eventFour, eventFive };
           // eventsList.Add(eventOne);
           // eventsList.Add(eventTwo);
           // eventsList.Add(eventThree);
           // eventsList.Add(eventFour);
           // eventsList.Add(eventFive);
            MyComboBox.ItemsSource = eventsList;
        }
        
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            ButtonLogin.IsEnabled = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = MyComboBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }
            var list = eventsList[index].ParticipantsList;
            this.MyDataGrid.ItemsSource = list;
        }

    }
}
