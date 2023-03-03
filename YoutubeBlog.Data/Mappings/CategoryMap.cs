using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("CC60A0F7-934B-480C-A634-B019F8E57369"),
                Name = "c# entity framework",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {
               
               
                    Id = Guid.Parse("0EA2F85B-E76E-4BB0-9C2C-7E2DF1A5C113"),
                    Name = "asp.net core ",
                    CreatedBy = "admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                
            }
                            
            );
      
        }
    }
}
