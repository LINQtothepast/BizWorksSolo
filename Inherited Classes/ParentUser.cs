using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserInfo : CreateUpdate
    {
        protected int userProfileTypeID;
        protected string username;
        protected string password;
        protected string workNumber;
        protected string faxNumber;
        protected string userEmail;
        
        //constructor
        public UserInfo(int profileTypeID, string user, string pass,
            string workNum, string faxNum, string email,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes, int guiID)
            : base (createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID)
        {
            UserProfileTypeID = profileTypeID;
            Username = user;
            Password = pass;
            WorkNumber = workNum;
            FaxNumber = faxNum;
            Email = email;
        }

        public int UserProfileTypeID
        {
            get { return userProfileTypeID; }
            set { userProfileTypeID = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string WorkNumber
        {
            get { return workNumber; }
            set { workNumber = value; }
        }
        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }
        public string Email
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        
    }
}