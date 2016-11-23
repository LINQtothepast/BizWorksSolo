using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployee : UserInfo
    {
        private int active;
        private string firstName;
        private string middleName;
        private string lastName;
        private int userPositionID;
        private DateTime dateOfBirth;
        private char userGender;
        private string homeNumber;
        private string mobile_1;
        private string mobile_2;
        private DateTime startDate;
        private DateTime endDate;

        //constructor
        public UserEmployee(int active, string first, string middle, string last,
            int profileTypeID, int postionID, string user, string pass,
            DateTime birth, char gender,
            string homeNum, string mobile1, string mobile2, string workNum,
            string faxNum, string email, DateTime start, DateTime end,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes, int guiID)
            : base (postionID, user, pass, workNum, faxNum, email,
                    createdOn, createdBy, lastUpdatedOn, lastUpdatedBy,
                    notes, guiID)
        {
            Active = active;
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            UserPositionID = postionID;
            DateOfBirth = birth;
            UserGender = gender;
            HomeNumber = homeNum;
            Mobile_1 = mobile1;
            Mobile_2 = mobile2;
            StartDate = start;
            EndDate = end;
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int UserPositionID
        {
            get { return userPositionID; }
            set { userPositionID = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public char UserGender
        {
            get { return userGender; }
            set { userGender = value; }
        }
        public string HomeNumber
        {
            get { return homeNumber; }
            set { homeNumber = value; }
        }
        public string Mobile_1
        {
            get { return mobile_1; }
            set { mobile_1 = value; }
        }
        public string Mobile_2
        {
            get { return mobile_2; }
            set { mobile_2 = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
