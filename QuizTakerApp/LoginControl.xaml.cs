using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace QuizTakerApp
{
    
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public event EventHandler LoginSuccess;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txt_Password.Text;
            string password = txt_userName.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Raise the LoginSuccess event
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please enter a username and password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
