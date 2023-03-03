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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                    Id = Guid.Parse("2FB21410-E80E-42BB-BA49-E07F16F9BF79"),
                    FileName = "image/testimage",
                    FileType = ".png",
                    CreatedBy = "admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                
            },
            new Image
            {
                Id = Guid.Parse("0F6CFC4B-D2D4-4F85-BAB2-33891CAEF37E"),
                FileName = "image/testimage",
                FileType = ".jpg",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
            );
        }
    }
}
