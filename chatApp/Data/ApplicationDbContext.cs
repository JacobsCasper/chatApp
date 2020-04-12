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

            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    UserName = "Alice@gmail.com",
                    NormalizedUserName = "ALICE@GMAIL.COM",
                    Email = "Alice@gmail.com",
                    NormalizedEmail = "ALICE@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEKTfaE2A8ArlEZZ6xEvvLmFuJmrH2KnKT4x/vddQUpB+nVlOodI0b8O/0plHhyVBow=="
                },
                new AppUser
                {
                    UserName = "Bob@gmail.com",
                    NormalizedUserName = "BOB@GMAIL.COM",
                    Email = "Bob@gmail.com",
                    NormalizedEmail = "BOB@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEKTfaE2A8ArlEZZ6xEvvLmFuJmrH2KnKT4x/vddQUpB+nVlOodI0b8O/0plHhyVBow=="
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
