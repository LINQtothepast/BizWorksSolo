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
using System.Globalization;

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for EmployeeAdd2.xaml
    /// </summary>
    public partial class EmployeeAdd2 : Window
    {
        private string sessionUserEmployeeAdd2;
        private string passedUsername;

        public EmployeeAdd2(string sessionUserEmployeeAdd1, string storedUsername)
        {
            InitializeComponent();
            sessionUserEmployeeAdd2 = sessionUserEmployeeAdd1;
            passedUsername = storedUsername;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string street1, city1, state1;
            string street2, city2, state2;
            string notes1, notes2;
            int zip1, zip2;
            DateTime dateRightNow = DateTime.Now;

            street1 = UserInputStreet1.Text;
            city1 = UserInputCity1.Text;
            state1 = UserInputState1.Text;
            zip1 = Convert.ToInt32(UserInputZip1.Text);
            notes1 = NotesTextBox1.Text;
            UserEmployeeAddressCollection.addUserAddress(passedUsername,
                    street1, city1, state1, zip1, dateRightNow,
                    sessionUserEmployeeAdd2, dateRightNow,
                    sessionUserEmployeeAdd2, notes1, 1);

            if (Address2Valid.Text == "Yes")
            {
                street2 = UserInputStreet2.Text;
                city2 = UserInputCity2.Text;
                state2 = UserInputState2.Text;
                zip2 = Convert.ToInt32(UserInputZip2.Text);
                notes2 = NotesTextBox2.Text;
                UserEmployeeAddressCollection.addUserAddress(passedUsername,
                    street2, city2, state2, zip2, dateRightNow,
                    sessionUserEmployeeAdd2, dateRightNow,
                    sessionUserEmployeeAdd2, notes2, 1);
            }
            else if (Address2Valid.Text == "No")
            { }

            EmployeeAdd3 main = new EmployeeAdd3(sessionUserEmployeeAdd2, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
