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
    /// Interaction logic for EmployeeAdd1.xaml
    /// </summary>
    public partial class EmployeeAdd1 : Window
    {
        private string sessionUserEmployeeAdd1;
        private string employeeAddUsernamePass;

        public EmployeeAdd1(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserEmployeeAdd1 = sessionUserMainMenu;     
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }


        private void Next_Click(object sender, RoutedEventArgs e)
        {
            int selectedProfileType = 0;
            string first, middle, last, dateBirth, dateStart;
            char selectedGender = 'N';
            string cellNumber1, cellNumber2, workNumber, fax;
            string userEmail, storedUsername, storedPassword;
            string homePhoneNumber, notes;
            first = FirstName.Text;
            middle = MiddleName.Text;
            last = LastName.Text;
            dateBirth = DateOfBirth.Text;
            dateStart = StartDate.Text;
            homePhoneNumber = HomePhone.Text;
            cellNumber1 = CellPhone1.Text;
            cellNumber2 = CellPhone2.Text;
            workNumber = WorkPhone.Text;
            fax = FaxNumber.Text;
            userEmail = Email.Text;
            storedUsername = Username.Text;
            storedPassword = Password.Text;
            notes = NotesTextBox.Text;
            if (ProfileType.Text == "Owner")
            {
                selectedProfileType = 1;
            }
            if (Gender.Text == "Male")
            {
                selectedGender = 'M';
            }
            else if(Gender.Text == "Female")
            {
                selectedGender = 'F';
            }
            else if (Gender.Text == "Attack Helicopter")
            {
                selectedGender = 'A';
            }

            DateTime dateRightNow = DateTime.Now;
            DateTime fakeQuitDate = new DateTime(2100, 1, 1);
            DateTime BirthDate = DateTime.Parse(dateBirth);
            DateTime DateofStart = DateTime.Parse(dateStart);

            //adds on to the back
            //so access with UserCollection.last();
            UserEmployeeCollection.addUser(1, first, middle, last, selectedProfileType, 1,
                storedUsername, storedPassword, BirthDate, selectedGender,
                homePhoneNumber, cellNumber1, cellNumber2, workNumber,
                fax, userEmail, DateofStart, fakeQuitDate,
                dateRightNow, sessionUserEmployeeAdd1,  dateRightNow,
                sessionUserEmployeeAdd1, notes, 1);

            employeeAddUsernamePass = storedUsername;
            EmployeeAdd2 main = new EmployeeAdd2(sessionUserEmployeeAdd1, storedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
