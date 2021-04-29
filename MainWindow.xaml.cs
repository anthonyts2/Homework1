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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginValidation();
        }

        private void LoginValidation()
        {
            if(uxName.Text.Length != 0 && uxPassword.Password.Length != 0)
            {
                uxSubmit.IsEnabled = true;        
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }    
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoginValidation();
        }

        private void uxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginValidation();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            //string username = uxName.Text;
            //string password = uxPassword.Password;
            uxName.Clear();
            uxPassword.Clear();
            MessageBox.Show("HELLO WORLD! Username and Password Cleared");
        }

    }
}
