using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class CreateUpdate
    {
        protected DateTime userCreatedOn;
        protected string userCreatedBy;
        protected DateTime userLastUpdatedOn;
        protected string userLastUpdatedBy;
        protected string userNotes;
        protected int userGuiID;

        public CreateUpdate(DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes,
            int guiID)
        {
            UserCreatedOn = createdOn;
            UserCreatedBy = createdBy;
            UserLastUpdatedOn = lastUpdatedOn;
            UserLastUpdatedBy = lastUpdatedBy;
            UserNotes = notes;
            UserGuiID = guiID;
        }


        public DateTime UserCreatedOn
        {
            get { return userCreatedOn; }
            set { userCreatedOn = value; }
        }
        public string UserCreatedBy
        {
            get { return userCreatedBy; }
            set { userCreatedBy = value; }
        }
        public DateTime UserLastUpdatedOn
        {
            get { return userLastUpdatedOn; }
            set { userLastUpdatedOn = value; }
        }
        public string UserLastUpdatedBy
        {
            get { return userLastUpdatedBy; }
            set { userLastUpdatedBy = value; }
        }
        public string UserNotes
        {
            get { return userNotes;}
            set { userNotes = value; }
        }
        public int UserGuiID
        {
            get { return userGuiID; }
            set { userGuiID = value; }
        }
    }
}
