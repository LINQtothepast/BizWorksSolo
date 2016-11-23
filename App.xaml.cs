using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Window1 wnd = new Window1();
            DateTime value = new DateTime(2016, 11, 1, 5, 20, 00); 
            //call for loading in users from database goes here.
            //below is a temporary test case object
            UserEmployeeCollection.addUser(1, "Derek", "Thomas", "Blankinship", 1, 1,
                "admin", "password", value, 'M', "574-123-1234", "574-234-2345",
                "N/A", "574-345-3456", "N/A", "sun@gmail.com", value,
                value, value, "admin", value, "admin",
                "no notes", 1);
            UserEmployeeAddressCollection.addUserAddress("admin", "exampleStreet1",
                "exampleCity1", "exampleState1", 12345, value, "admin", value, "admin", "no notes", 1);
            UserEmployeeAddressCollection.addUserAddress("admin", "exampleStreet2",
                "exampleCity2", "exampleState2", 23456, value, "admin", value, "admin", "no notes", 1);
            UserEmployeeEmergencyCollection.addUserEmergencyContact("admin", "Tara", "Blankinship",
                "574-567-8901", "wife", value, "admin", value, "admin", "no notes", 1);


            UserEmployeeCollection.addUser(1, "Hunter", "A", "Johnson", 1, 1,
                "user", "12345", value, 'M', "574-123-1234", "574-234-2345",
                "N/A", "574-345-3456", "N/A", "sun@gmail.com", value,
                value, value, "admin", value, "admin",
                "no notes", 1);
            wnd.Show();
        }

    }
}
