using HW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW;

public class LibraryDbConetext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-0RGINKQ\\SQLEXPRESS;Initial Catalog=EF;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<BookTypes> BookTypes { get; set; }
    public DbSet<Operations> Operations { get; set; }
    public DbSet<Students> Students { get; set; }
}
