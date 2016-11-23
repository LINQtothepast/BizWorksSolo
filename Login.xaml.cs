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


namespace BizWorks
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string sessionUserLogin;
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool validCredentials = false;
            string enteredUsername;
            string enteredPassword;            
            enteredUsername = Username_Textbox.Text;
            enteredPassword = Password_Textbox.Text;
            validCredentials = UserEmployeeCollection.checkCredentials(enteredUsername, enteredPassword);
            if (validCredentials == false)
            {
                MessageBox.Show("Invalid Input. Please Retry");
            }
            else
            {
                sessionUserLogin = enteredUsername;
                MainMenu main = new MainMenu(sessionUserLogin);
                App.Current.MainWindow = main;
                this.Close();
                main.Show();
            }
        }
        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
    }
}
