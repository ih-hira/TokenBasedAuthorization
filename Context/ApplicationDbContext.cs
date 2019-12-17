using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TouchAntenna.Models;
using Microsoft.EntityFrameworkCore;

namespace TouchAntenna.Context
{
    public class ApplicationDbContext: DbContext
    {
        public IConfiguration Configuration { get; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(Configuration["ConnectionStrings:DefaultConnection"]);
        //}
        public DbSet<SMS_USER_PROFILE> ApplicationUser { get; set; }
    }
}
