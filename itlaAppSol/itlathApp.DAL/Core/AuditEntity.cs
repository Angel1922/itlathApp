using System;

namespace itlathApp.DAL.Core
{
    public class AuditEntity
    {
        public AuditEntity()
        {
            this.CreationDate = DateTime.Now;
            this.deleted = false;
        }

        public int CreationUser { get; set; }

        public DateTime CreationDate {get; set;}

        public int UserMod { get; set;}

        public DateTime ModifyDate { get; set; }

        public int UserDeleted { get; set; }

        public bool deleted { get; set; }

    }
}
