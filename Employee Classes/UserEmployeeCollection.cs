using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployeeCollection
    {
        private static List<UserEmployee> EmployeeList = new List<UserEmployee>();

        public static void addUser(int active, string first,
            string middle, string last, int profileTypeID,
            int postionID, string user, string pass, DateTime birth, char gender,
            string homeNum, string mobile1, string mobile2, string workNum,
            string faxNum, string email, DateTime start, DateTime end,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes, int guiID)
        {
            EmployeeList.Add(new UserEmployee(active, first, middle, last, profileTypeID,
                postionID, user, pass, birth, gender, homeNum, mobile1,
                mobile2, workNum, faxNum, email, start, end, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID));
        }

        public static void ModifyUser(int active, string first,
            string middle, string last, int profileTypeID,
            int postionID, string user, string pass, DateTime birth, char gender,
            string homeNum, string mobile1, string mobile2, string workNum,
            string faxNum, string email, DateTime start, DateTime end,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes, int guiID, string storedUsername)
        {
            foreach (var element in EmployeeList)
            {
                if (element.Username == storedUsername)
                {
                    element.Active = active;
                    element.FirstName = first;
                    element.MiddleName = middle;
                    element.LastName = last;
                    element.UserProfileTypeID = profileTypeID;                    
                    element.UserPositionID = postionID;
                    element.Username = user;
                    element.Password = pass;
                    element.DateOfBirth = birth;
                    element.UserGender = gender;
                    element.HomeNumber = homeNum;
                    element.Mobile_1 = mobile1;
                    element.Mobile_2 = mobile2;
                    element.WorkNumber = workNum;
                    element.FaxNumber = faxNum;
                    element.Email = email;
                    element.StartDate = start;
                    element.EndDate = end;
                    element.UserCreatedOn = createdOn;
                    element.UserCreatedBy = createdBy;
                    element.UserLastUpdatedOn = lastUpdatedOn;
                    element.UserLastUpdatedBy = lastUpdatedBy;
                    element.UserNotes = notes;
                    element.UserGuiID = guiID;
                }
            }
        }

        public static void DeactivateUser(string storedUsername)
        {
            foreach (var element in EmployeeList)
            {
                if (element.Username == storedUsername)
                {
                    element.Active = 0;
                }
            }
        }

        public static bool checkCredentials(string passedUser, string passedPassword)
        {
            bool valid = false;

            var filtered =
                        from element in EmployeeList
                        where element.Username == passedUser
                        select element;
            
            foreach (var element in filtered)
            {
                if (element.Password == passedPassword)
                {
                    valid = true;
                }
            }

            return valid;
        }

        public static List<UserEmployee> ReturnAList()
        {
            List < UserEmployee > theList = new List<UserEmployee>();
            theList = EmployeeList;

            return theList;
        }

        public static int GetProfileType(string username)
        {
            int x = 0;
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.UserProfileTypeID;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetFirstName(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.FirstName;
            foreach (var item in query){ x = item; }
            return x;
        }
        public static string GetMiddleName(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.MiddleName;
            foreach (var item in query){ x = item; }
            return x;
        }
        public static string GetLastName(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.LastName;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetDateOfBirth(string username)
        {
            DateTime x = new DateTime(2016, 11, 1, 5, 20, 00);
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.DateOfBirth;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static char GetGender(string username)
        {
            char x = 'a';
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.UserGender;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetStartDate(string username)
        {
            DateTime x = new DateTime(2016, 11, 1, 5, 20, 00);
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.StartDate;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetMobilePhone1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.Mobile_1 ;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetMobilePhone2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.Mobile_2;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetWorkPhone(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.WorkNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetFaxNumber(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.FaxNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetHomePhone(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.HomeNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetEmail(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.Email;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetNotes(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.UserNotes;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetPassword(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeList
                where employee.Username == username
                select employee.Password;
            foreach (var item in query) { x = item; }
            return x;
        }
    }  
}
