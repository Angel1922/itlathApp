using System;

namespace itlathApp.DAL.Repositories
{
    public class ItlaContext
    {
        public bool Any { get; internal set; }
        public object Students { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}