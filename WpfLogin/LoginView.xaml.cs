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

namespace WpfLogin_UserControl_4
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {

            string passwordEntered = passwordBox.Password;
            string correctPassword = "password";

            if (passwordEntered != null)
            {
                if (passwordEntered == correctPassword)
                {
                    MessageBox.Show("Enterd Correct Password");
                }
                else
                {
                    MessageBox.Show("Entered Wrong Password");
                }
            }
            else { MessageBox.Show("Nothing Entered"); }




            // Get evnironment varialbes 
            //string? evnPw = Environment.GetEnvironmentVariable("InvoiceManagment");

            //if (evnPw != null)
            //{
            //    if (passwordEntered == evnPw)
            //    {
            //        MessageBox.Show("Enterd Correct Password");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Entered Wrong Password");
            //    }
            //}
        }
    }
}
