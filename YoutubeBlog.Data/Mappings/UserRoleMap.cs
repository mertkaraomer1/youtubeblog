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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId=Guid.Parse("D8987127-2E86-4FD4-8E1F-A9388412B5F7"),
                RoleId=Guid.Parse("1907D832-F2DE-4C2A-A5C4-3DB68079C325")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("28D6D892-4538-45C1-98A9-5F7240FBC590"),
                RoleId = Guid.Parse("6E9391B8-6966-44EE-8E5A-31C824B1BA62")
            });
        }
    }
}
