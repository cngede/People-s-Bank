using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBank.Models;

namespace OnlineBank.Data
{
    public class ApplicationDbContext : IdentityDbContext
        {

        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                      
           optionsBuilder.UseSqlite(Configuration.GetConnectionString("OnlineBank"));
         
        }

        //Adding Domain Classes as DbSet Properties
        public DbSet<Account> Account { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Statement> Statement { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
        
        
       
        }
    }
