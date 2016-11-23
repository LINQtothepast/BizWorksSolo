using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployeeEmergencyCollection
    {
        private static List<EmergencyContact> EmployeeEmergencyContactList = new List<EmergencyContact>();

        public static void addUserEmergencyContact(string Username, string eFirst,
            string eLast, string ePhoneNumber,
            string eRelation, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            EmployeeEmergencyContactList.Add(new EmergencyContact(Username, eFirst,
                eLast, ePhoneNumber, eRelation, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID));
        }

        public static void ModifyUserEmergencyContact1(string passedUsername, string eFirst,
            string eLast, string ePhoneNumber,
            string eRelation, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            foreach (var element in EmployeeEmergencyContactList
                .Where(element => element.Username == passedUsername).Take(1))
            {
                element.FirstName = eFirst;
                element.LastName = eLast;
                element.PhoneNumber = ePhoneNumber;
                element.Relation = eRelation;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
                element.UserGuiID = guiID;
            }
        }

        public static void ModifyUserEmergencyContact2(string passedUsername, string eFirst,
            string eLast, string ePhoneNumber,
            string eRelation, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            int count = 0;
            foreach (var element in EmployeeEmergencyContactList
                .Where(element => element.Username == passedUsername))
            {
                count++;
            }

            if (count == 1)
            {
                EmployeeEmergencyContactList.Add(new EmergencyContact(passedUsername, eFirst,
                eLast, ePhoneNumber, eRelation, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID));
            }
            else if (count == 2)
            {
                foreach (var element in EmployeeEmergencyContactList
                .Where(element => element.Username == passedUsername).Skip(1))
                {
                    element.FirstName = eFirst;
                    element.LastName = eLast;
                    element.PhoneNumber = ePhoneNumber;
                    element.Relation = eRelation;
                    element.UserCreatedOn = createdOn;
                    element.UserCreatedBy = createdBy;
                    element.UserLastUpdatedOn = lastUpdatedOn;
                    element.UserLastUpdatedBy = lastUpdatedBy;
                    element.UserNotes = notes;
                    element.UserGuiID = guiID;
                }
            }
        }

        public static void DeleteUserEmergencyContact2(string passedUsername)
        {
            foreach (var element in EmployeeEmergencyContactList
                .Where(element => element.Username == passedUsername).Skip(1))
            {
                EmployeeEmergencyContactList.Remove(element);
            }
        }

        public static string GetFirstName1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.FirstName;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetLastName1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.LastName;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetPhone1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.PhoneNumber;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetRelation1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.Relation;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetNotes1(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.UserNotes;
            foreach (var item in query)
            {
                x = item;
                break;
            }
            return x;
        }
        public static string GetFirstName2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.FirstName;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetLastName2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.LastName;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetPhone2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.PhoneNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetRelation2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.Relation;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetNotes2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.UserNotes;
            foreach (var item in query) { x = item; }
            return x;
        }



    }
}
