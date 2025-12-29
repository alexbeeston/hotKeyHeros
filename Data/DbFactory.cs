using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotKeyHeros.Data
{
    public class LocalDbFactory : IDesignTimeDbContextFactory<LocalDbContext>
    {
        public LocalDbContext CreateDbContext(string[] args)
        {
            return new LocalDbContext(new DbContextOptionsBuilder().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotKeyHeros;Integrated Security=SSPI").Options);
        }
    }
}
