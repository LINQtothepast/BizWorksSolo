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
    /// Interaction logic for EmployeeAddressModify.xaml
    /// </summary>
    public partial class EmployeeAddressModify : Window
    {
        private string sessionUserEmployeeAddressModify;
        private string passedUsername;

        public EmployeeAddressModify(string sessionUserEmployeeShow, string storedUsername)
        {
            InitializeComponent();
            sessionUserEmployeeAddressModify = sessionUserEmployeeShow;
            passedUsername = storedUsername;
            //set Address Fields
            UserInputStreet1.Text = UserEmployeeAddressCollection.GetStreet1(passedUsername);
            UserInputCity1.Text = UserEmployeeAddressCollection.GetCity1(passedUsername);
            UserInputState1.Text = UserEmployeeAddressCollection.GetState1(passedUsername);
            UserInputZip1.Text = UserEmployeeAddressCollection.GetZipCode1(passedUsername).ToString();
            NotesTextBox1.Text = UserEmployeeAddressCollection.GetNotes1(passedUsername);

            string x, y;
            x = UserEmployeeAddressCollection.GetStreet1(passedUsername);
            y = UserEmployeeAddressCollection.GetStreet2(passedUsername);
            if (x != y)
            {
                UserInputStreet2.Text = UserEmployeeAddressCollection.GetStreet2(passedUsername);
                UserInputCity2.Text = UserEmployeeAddressCollection.GetCity2(passedUsername);
                UserInputState2.Text = UserEmployeeAddressCollection.GetState2(passedUsername);
                UserInputZip2.Text = UserEmployeeAddressCollection.GetZipCode2(passedUsername).ToString();
                NotesTextBox2.Text = UserEmployeeAddressCollection.GetNotes2(passedUsername);
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
            UserEmployeeAddressCollection.ModifyUserAddress1(passedUsername,
                    street1, city1, state1, zip1, dateRightNow,
                    sessionUserEmployeeAddressModify, dateRightNow,
                    sessionUserEmployeeAddressModify, notes1, 1);

            if (Address2Valid.Text == "Yes")
            {
                street2 = UserInputStreet2.Text;
                city2 = UserInputCity2.Text;
                state2 = UserInputState2.Text;
                zip2 = Convert.ToInt32(UserInputZip2.Text);
                notes2 = NotesTextBox2.Text;
                UserEmployeeAddressCollection.ModifyUserAddress2(passedUsername,
                    street2, city2, state2, zip2, dateRightNow,
                    sessionUserEmployeeAddressModify, dateRightNow,
                    sessionUserEmployeeAddressModify, notes2, 1);
            }
            else if (Address2Valid.Text == "No")
            {
                UserEmployeeAddressCollection.DeleteUserAddress2(passedUsername);
            }

            EmployeeShow main = new EmployeeShow(sessionUserEmployeeAddressModify, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
