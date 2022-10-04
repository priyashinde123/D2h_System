using D2h_System.Operations;
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
    /// Interaction logic for CustomerLogin.xaml
    /// </summary>
    

    public partial class CustomerLogin : Window
    {
       private static string _connectionString = @"Data Source=DESKTOP-7K173KI\SQL2016EXPRESS;Initial Catalog=DTH_SYSTEM;Persist Security Info=True;User ID=sa;Password=aa";
       private static CustomerOperations cust_Operations = new CustomerOperations(_connectionString);
        public CustomerLogin()
        {
            InitializeComponent();
        }

        

        private void CustomerDashboard(object sender, RoutedEventArgs e)
        {

            bool isvalid = cust_Operations.IsValidateLogin(txtinput1.Text, txtinput2.Text);
          //  bool isvalid = false;
            if (isvalid)
            {
                this.Visibility = Visibility.Hidden;
                Customer_Dashborad cust = new Customer_Dashborad();
                cust.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Wrong Credentials");
        }
             public void window_cloased(object sender,EventArgs e)
        {
            this.Visibility=Visibility.Hidden;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Visibility = Visibility.Visible;
        }
    }
}
