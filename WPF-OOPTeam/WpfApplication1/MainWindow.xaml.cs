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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            var colllect = new List<Admin>
                {
                        
                        new Admin { Event = 1, Name = "Nomer1"},
                        new Admin { Event = 2, Name = "Nomer2"},
                        new Admin { Event = 3, Name = "Nomer3"},
                        new Admin { Event = 4, Name = "Nomer4"},
                        new Admin { Event = 5, Name = "Nomer5"},
                        new Admin { Event = 6, Name = "Nomer6"},
                };

            
            MyDataGrid.ItemsSource = colllect;
            
        }
        
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            ButtonLogin.IsEnabled = false;
        }

    }
}
