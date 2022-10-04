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
using System.Windows.Shapes;

namespace D2h_System
{
    /// <summary>
    /// Interaction logic for AgentLogin.xaml
    /// </summary>
    public partial class AgentLogin : Window
    {
        public AgentLogin()
        {
            InitializeComponent();
        }

        private void AgentDashboard(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Agent_Dashboard agent = new Agent_Dashboard();
            agent.Visibility = Visibility.Visible;
        }
    }
}
