using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployeeAddressCollection
    {
        private static List<Address> EmployeeAddressList = new List<Address>();

        public static void addUserAddress(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            EmployeeAddressList.Add(new Address(profileName, addressStreet,
                addressCity, addressState, addressZipCode, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID));
        }

        public static void ModifyUserAddress1(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            foreach (var element in EmployeeAddressList
                .Where(element => element.UserProfileName == profileName).Take(1))
            {
                element.UserAddressStreet = addressStreet;
                element.UserAddressCity = addressCity;
                element.UserAddressState = addressState;
                element.UserAddressZipCode = addressZipCode;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
                element.UserGuiID = guiID;
            } 
        }

        public static void ModifyUserAddress2(string profileName, string addressStreet,
           string addressCity, string addressState,
           int addressZipCode, DateTime createdOn,
           string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
           string notes, int guiID)
        {
            int count = 0;
            foreach (var element in EmployeeAddressList
                .Where(element => element.UserProfileName == profileName))
            {
                count++;
            }

            if (count == 1)
            {
                EmployeeAddressList.Add(new Address(profileName, addressStreet,
                addressCity, addressState, addressZipCode, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID));
            }
            else if (count == 2)
            {
                foreach (var element in EmployeeAddressList
                .Where(element => element.UserProfileName == profileName).Skip(1))
                {
                    element.UserAddressStreet = addressStreet;
                    element.UserAddressCity = addressCity;
                    element.UserAddressState = addressState;
                    element.UserAddressZipCode = addressZipCode;
                    element.UserCreatedOn = createdOn;
                    element.UserCreatedBy = createdBy;
                    element.UserLastUpdatedOn = lastUpdatedOn;
                    element.UserLastUpdatedBy = lastUpdatedBy;
                    element.UserNotes = notes;
                    element.UserGuiID = guiID;
                }
            }
        }

        public static void DeleteUserAddress2(string passedUsername)
        {
            foreach (var element in EmployeeAddressList
                .Where(element => element.UserProfileName == passedUsername).Skip(1))
            {
                EmployeeAddressList.Remove(element);
            }
        }

        public static string GetStreet1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressStreet;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetCity1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressCity;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetState1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressState;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static int GetZipCode1(string passedUsername)
        {
            int x = 0;
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressZipCode;
            foreach(var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetNotes1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserNotes;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetStreet2(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressStreet;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetCity2(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressCity;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetState2(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressState;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static int GetZipCode2(string passedUsername)
        {
            int x = 0;
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressZipCode;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetNotes2(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserNotes;
            foreach (var item in query) { x = item; }
            return x;
        }
    }
}
