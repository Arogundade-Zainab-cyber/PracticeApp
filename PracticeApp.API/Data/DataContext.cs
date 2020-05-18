using Microsoft.EntityFrameworkCore;
using PracticeApp.API.Models;

namespace PracticeApp.API.Data
{
    public class DataContext : DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) : base (options)  {}
             public DbSet<Value> Values { get; set; }
        
    }
}