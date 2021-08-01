using Microsoft.EntityFrameworkCore;
using API.Entity;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet <AppUser> Users{get;set;}

    }
}