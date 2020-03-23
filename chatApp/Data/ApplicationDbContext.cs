using System;
using System.Collections.Generic;
using System.Text;
using chatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace chatApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
                .HasOne<AppUser>(a => a.Sender)
                .WithMany(m => m.Messages)
                .HasForeignKey(m => m.UserId);
            base.OnModelCreating(builder);
        }
    }
}
