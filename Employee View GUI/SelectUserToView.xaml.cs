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
    /// Interaction logic for SelectUserToView.xaml
    /// </summary>
    public partial class SelectUserToView : Window
    {
        private string sessionUserSelectUserToView;
        private string passedUsername;

        public SelectUserToView(string sessionUserMainMenu)
        {
            passedUsername = sessionUserMainMenu;
            sessionUserSelectUserToView = sessionUserMainMenu;
            InitializeComponent();

            List<UserEmployee> ListOfEmployees = new List<UserEmployee>();
            ListOfEmployees = UserEmployeeCollection.ReturnAList();

            var tempList =
                from employee in ListOfEmployees
                where employee.Active == 1
                select new
                {
                    Name = employee.FirstName + " " + employee.LastName,
                    Position = employee.UserPositionID,
                    Username = employee.Username,
                    StartDate = employee.StartDate,
                    Email = employee.Email,
                    CreatedBy = employee.UserCreatedBy,
                    CreatedOn = employee.UserCreatedOn,
                    UpdatedBy = employee.UserLastUpdatedBy,
                    UpdatedOn = employee.UserLastUpdatedOn
                };

            this.EmployeeListSelect.ItemsSource = tempList;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeShow main = new EmployeeShow(sessionUserSelectUserToView, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void EmployeeListSelect_CellClick(object sender, SelectedCellsChangedEventArgs e)
        {
            //passedUsername = EmployeeListSelect.Columns[2].GetValue();
        }
    }
}
