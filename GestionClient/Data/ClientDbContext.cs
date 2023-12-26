using GestionClient.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionClient.Data
{
    public class ClientDbContext:DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
    }
}
