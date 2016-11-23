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

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for EmployeeAdd3.xaml
    /// </summary>
    public partial class EmployeeAdd3 : Window
    {
        private string sessionUserEmployeeAdd3;
        private string passedUsername;
        public EmployeeAdd3(string sessionUserEmployeeAdd2, string storedUsername)
        {
            InitializeComponent();
            sessionUserEmployeeAdd3 = sessionUserEmployeeAdd2;
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
            string firstName1, lastName1, phone1, relation1;
            string firstName2, lastName2, phone2, relation2;
            string notes1, notes2;
            DateTime dateRightNow = DateTime.Now;

            firstName1 = UserInputFirstName1.Text;
            lastName1 = UserInputLastName1.Text;
            phone1 = UserInputPhone1.Text;
            relation1 = UserInputRelation1.Text;
            notes1 = eNotesTextBox1.Text;
            UserEmployeeEmergencyCollection.addUserEmergencyContact(passedUsername,
                    firstName1, lastName1, phone1, relation1, dateRightNow,
                    sessionUserEmployeeAdd3, dateRightNow,
                    sessionUserEmployeeAdd3, notes1, 1);

            if (eContact2Valid.Text == "Yes")
            {
                firstName2 = UserInputFirstName2.Text;
                lastName2 = UserInputLastName2.Text;
                phone2 = UserInputPhone2.Text;
                relation2 = UserInputRelation2.Text;
                notes2 = eNotesTextBox2.Text;
                UserEmployeeEmergencyCollection.addUserEmergencyContact(passedUsername,
                        firstName2, lastName2, phone2, relation2, dateRightNow,
                        sessionUserEmployeeAdd3, dateRightNow,
                        sessionUserEmployeeAdd3, notes2, 1);
            }
            else if (eContact2Valid.Text == "No")
            { }

            EmployeeShow main = new EmployeeShow(sessionUserEmployeeAdd3, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
