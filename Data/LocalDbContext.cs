using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data;

public class LocalDbContext : DbContext
{
    public LocalDbContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }

    public DbSet<DataCollectionEntity> Collections { get; set; }
}
