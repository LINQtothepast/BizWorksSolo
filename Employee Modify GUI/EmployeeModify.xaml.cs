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
    /// Interaction logic for EmployeeModify.xaml
    /// </summary>
    public partial class EmployeeModify : Window
    {
        private string sessionUserModifyEmployee;
        private string passedUsername;

        public EmployeeModify(string sessionUser, string storedUsername)
        {
            passedUsername = storedUsername;
            sessionUserModifyEmployee = sessionUser;

            InitializeComponent();
            int holderVariable = UserEmployeeCollection.GetProfileType(passedUsername);
            if (holderVariable == 1)
            { ProfileType.Text = "Owner"; }
            FirstName.Text = UserEmployeeCollection.GetFirstName(passedUsername);
            MiddleName.Text = UserEmployeeCollection.GetMiddleName(passedUsername);
            LastName.Text = UserEmployeeCollection.GetLastName(passedUsername);
            DateOfBirth.Text = UserEmployeeCollection.GetDateOfBirth(passedUsername).ToShortDateString();
            StartDate.Text = UserEmployeeCollection.GetStartDate(passedUsername).ToShortDateString();
            CellPhone1.Text = UserEmployeeCollection.GetMobilePhone1(passedUsername);
            CellPhone2.Text = UserEmployeeCollection.GetMobilePhone2(passedUsername);
            WorkPhone.Text = UserEmployeeCollection.GetWorkPhone(passedUsername);
            FaxNumber.Text = UserEmployeeCollection.GetFaxNumber(passedUsername);
            HomePhone.Text = UserEmployeeCollection.GetHomePhone(passedUsername);
            Email.Text = UserEmployeeCollection.GetEmail(passedUsername);
            NotesTextBox.Text = UserEmployeeCollection.GetNotes(passedUsername);

            char tempGender = UserEmployeeCollection.GetGender(passedUsername);
            if (tempGender == 'M')
            {
                Gender.Text = "Male";
            }
            else if (tempGender == 'F')
            {
                Gender.Text = "Female";
            }
            else if (tempGender == 'A')
            {
                Gender.Text = "Attack Helicopter";
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
            int selectedProfileType = 0;
            string first, middle, last, dateBirth, dateStart;
            char selectedGender = 'N';
            string cellNumber1, cellNumber2, workNumber, fax;
            string userEmail, storedPassword;
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
            storedPassword = UserEmployeeCollection.GetPassword(passedUsername);
            notes = NotesTextBox.Text;
            if (ProfileType.Text == "Owner")
            {
                selectedProfileType = 1;
            }
            if (Gender.Text == "Male")
            {
                selectedGender = 'M';
            }
            else if (Gender.Text == "Female")
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
            UserEmployeeCollection.ModifyUser(1, first, middle, last, selectedProfileType, 1,
                passedUsername, storedPassword, BirthDate, selectedGender,
                homePhoneNumber, cellNumber1, cellNumber2, workNumber,
                fax, userEmail, DateofStart, fakeQuitDate,
                dateRightNow, sessionUserModifyEmployee, dateRightNow,
                sessionUserModifyEmployee, notes, 1, passedUsername);

            EmployeeShow main = new EmployeeShow(sessionUserModifyEmployee, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
