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
    /// Interaction logic for UserChangeToInactive.xaml
    /// </summary>
    public partial class UserChangeToInactive : Window
    {
        private string passedUsername;
        private string sessionUserEmployeeDelete;

        public UserChangeToInactive(string sessionUser, string storedUsername)
        {
            InitializeComponent();

            passedUsername = storedUsername;
            sessionUserEmployeeDelete = sessionUser;

            UserName.Content = passedUsername;
            int holderVariable = UserEmployeeCollection.GetProfileType(passedUsername);
            if (holderVariable == 1)
            { ProfileType.Content = "Owner"; }
            FirstName.Content = UserEmployeeCollection.GetFirstName(passedUsername);
            MiddleName.Content = UserEmployeeCollection.GetMiddleName(passedUsername);
            LastName.Content = UserEmployeeCollection.GetLastName(passedUsername);
            DateOfBirth.Content = UserEmployeeCollection.GetDateOfBirth(passedUsername);
            Gender.Content = UserEmployeeCollection.GetGender(passedUsername);
            StartDate.Content = UserEmployeeCollection.GetStartDate(passedUsername);
            CellPhone1.Content = UserEmployeeCollection.GetMobilePhone1(passedUsername);
            CellPhone2.Content = UserEmployeeCollection.GetMobilePhone2(passedUsername);
            WorkPhone.Content = UserEmployeeCollection.GetWorkPhone(passedUsername);
            FaxPhone.Content = UserEmployeeCollection.GetFaxNumber(passedUsername);
            HomePhone.Content = UserEmployeeCollection.GetHomePhone(passedUsername);
            Email.Content = UserEmployeeCollection.GetEmail(passedUsername);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu(sessionUserEmployeeDelete);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void Deactivate_Click(object sender, RoutedEventArgs e)
        {
            UserEmployeeCollection.DeactivateUser(passedUsername);
            MainMenu main = new MainMenu(sessionUserEmployeeDelete);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
