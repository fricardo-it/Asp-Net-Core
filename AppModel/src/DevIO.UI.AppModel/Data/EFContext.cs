using DevIO.UI.AppModel.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.UI.AppModel.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions options)
        : base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}

// PM console: 
// add-migration "Initial" -Context -Verbose 
// update-database -verbose
