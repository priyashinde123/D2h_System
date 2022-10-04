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

namespace D2h_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomerLogin(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            CustomerLogin cust = new CustomerLogin();
            cust.Visibility = Visibility.Visible;

        }

        private void AgentLogin(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            AgentLogin cust = new AgentLogin();
            cust.Visibility = Visibility.Visible;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }



        /*
        private void Customer_dashboard(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Customer_Dashborad cust=new Customer_Dashborad();
            cust.Visibility = Visibility.Visible;

        }

        private void agent_dashboard(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Agent_Dashboard agent=new Agent_Dashboard();
            agent.Visibility = Visibility.Visible;
        }*/
    }
}
