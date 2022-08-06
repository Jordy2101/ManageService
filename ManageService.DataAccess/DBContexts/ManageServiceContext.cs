using ManageService.Domain.ManageService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.DataAccess.DBContexts
{
    public class ManageServiceContext : DbContext
    {
        public ManageServiceContext(DbContextOptions<ManageServiceContext> options) : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<ClientAdress> ClientAdress { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TypeService> TypeService { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
