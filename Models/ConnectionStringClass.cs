using System;
using Microsoft.EntityFrameworkCore;

namespace olcutBelirleme.Models

{
    public class ConnectionStringClass : DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options) : base(options) 
        {

        }

        public DbSet<NotlarClass> Notlar { get; set; }
    }
}
