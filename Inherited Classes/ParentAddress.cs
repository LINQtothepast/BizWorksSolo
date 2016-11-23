using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class Address : CreateUpdate
    {
        private string userProfileName;
        private string userAddressStreet;
        private string userAddressCity;
        private string userAddressState;
        private int userAddressZipCode;
        
        //constructor               
        public Address(string profileName, string addressStreet, string addressCity,
            string addressState, int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID) 
            : base(createdOn, createdBy, lastUpdatedOn,
                  lastUpdatedBy, notes, guiID)
        {
            UserProfileName = profileName;
            UserAddressStreet = addressStreet;
            UserAddressCity = addressCity;
            UserAddressState = addressState;
            UserAddressZipCode = addressZipCode;
        }

        //properties
        public string UserProfileName
        {
            get { return userProfileName; }
            set { userProfileName = value; }
        }
        public string UserAddressStreet
        {
            get { return userAddressStreet; }
            set { userAddressStreet = value; }
        }
        public string UserAddressCity
        {
            get { return userAddressCity; }
            set { userAddressCity = value; }
        }
        public string UserAddressState
        {
            get { return userAddressState; }
            set { userAddressState = value; }
        }
        public int UserAddressZipCode
        {
            get { return userAddressZipCode; }
            set { userAddressZipCode = value; }
        }
    }
}
