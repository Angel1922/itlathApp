using itlathApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace itlathApp.DAL.context
{
    public class SchoolContext : DbContext
    {

        #region "Registros"
         public DbSet<Student> Students { get; set; }
        #endregion
    }
};