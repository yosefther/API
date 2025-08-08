using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{


    public class AppDpContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public AppDpContext(DbContextOptions<AppDpContext> options) : base(options)
        {

        }

    }

}