using DatabaseExample.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseExample.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
        {
            
        }

        // Examples is the table name
        public DbSet<ExampleModel> Examples { get; set; }
    }
}
