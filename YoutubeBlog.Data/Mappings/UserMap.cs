using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            var superadmin = new AppUser
            {
                Id = Guid.Parse("B974D702-9944-4209-BB4B-6EAC85277EDD"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMİN@GMAİL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMİN@GMAİL.COM",
                PhoneNumber = "+9005432142541",
                Firstname = "mert",
                Lastname = "karaömer",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "12345");

            var admin = new AppUser
            {
                Id = Guid.Parse("EACAEE81-B3C8-4DD0-9941-039166936AF7"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMİN@GMAİL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMİN@GMAİL.COM",
                PhoneNumber = "+9005432142531",
                Firstname = "özge",
                Lastname = "karaömer",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            admin.PasswordHash = CreatePasswordHash(admin, "12345");
            builder.HasData(superadmin, admin);
        }
        private string CreatePasswordHash(AppUser user,string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
