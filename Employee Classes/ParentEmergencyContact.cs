using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class EmergencyContact : CreateUpdate
    {
        private string username;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string relation;

        //constructor
        public EmergencyContact(string user, string first,
            string last, string phone, string relation,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes, int guiID)
            : base (createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes, guiID)
        {
            Username = user;
            FirstName = first;
            LastName = last;
            PhoneNumber = phone;
            Relation = relation;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }
    }
}
