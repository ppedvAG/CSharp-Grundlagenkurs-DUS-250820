using M19_Demo_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
// using System.Data.Entity;
using System.Text;

namespace M19_Demo_Entity_Framework
{
    class EFDbContext : DbContext
    {
        public DbSet<Transportmittel> DieTransportmittel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite("Data Source=TransportDB.db");

        
    }
}
