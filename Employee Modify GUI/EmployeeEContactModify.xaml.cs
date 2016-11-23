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
    /// Interaction logic for EmployeeEContactModify.xaml
    /// </summary>
    public partial class EmployeeEContactModify : Window
    {
        private string sessionUserEContactModify;
        private string passedUsername;
        public EmployeeEContactModify(string sessionUserEmployeeShow, string storedUsername)
        {
            InitializeComponent();
            sessionUserEContactModify = sessionUserEmployeeShow;
            passedUsername = storedUsername;

            //set Emergency Contact Fields
            UserInputFirstName1.Text = UserEmployeeEmergencyCollection.GetFirstName1(passedUsername);
            UserInputLastName1.Text = UserEmployeeEmergencyCollection.GetLastName1(passedUsername);
            UserInputPhone1.Text = UserEmployeeEmergencyCollection.GetPhone1(passedUsername);
            UserInputRelation1.Text = UserEmployeeEmergencyCollection.GetRelation1(passedUsername);
            eNotesTextBox1.Text = UserEmployeeEmergencyCollection.GetNotes1(passedUsername);

            string a, b;
            a = UserEmployeeEmergencyCollection.GetFirstName1(passedUsername);
            b = UserEmployeeEmergencyCollection.GetFirstName2(passedUsername);
            if (a != b)
            {
                UserInputFirstName2.Text = UserEmployeeEmergencyCollection.GetFirstName2(passedUsername);
                UserInputLastName2.Text = UserEmployeeEmergencyCollection.GetLastName2(passedUsername);
                UserInputPhone2.Text = UserEmployeeEmergencyCollection.GetPhone2(passedUsername);
                UserInputRelation2.Text = UserEmployeeEmergencyCollection.GetRelation2(passedUsername);
                eNotesTextBox2.Text = UserEmployeeEmergencyCollection.GetNotes2(passedUsername);
            }
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
            UserEmployeeEmergencyCollection.ModifyUserEmergencyContact1(passedUsername,
                    firstName1, lastName1, phone1, relation1, dateRightNow,
                    sessionUserEContactModify, dateRightNow,
                    sessionUserEContactModify, notes1, 1);

            if (eContact2Valid.Text == "Yes")
            {
                firstName2 = UserInputFirstName2.Text;
                lastName2 = UserInputLastName2.Text;
                phone2 = UserInputPhone2.Text;
                relation2 = UserInputRelation2.Text;
                notes2 = eNotesTextBox2.Text;
                UserEmployeeEmergencyCollection.ModifyUserEmergencyContact2(passedUsername,
                        firstName2, lastName2, phone2, relation2, dateRightNow,
                        sessionUserEContactModify, dateRightNow,
                        sessionUserEContactModify, notes2, 1);
            }
            else if (eContact2Valid.Text == "No")
            {
                UserEmployeeEmergencyCollection.DeleteUserEmergencyContact2(passedUsername);
            }

            EmployeeShow main = new EmployeeShow(sessionUserEContactModify, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}

