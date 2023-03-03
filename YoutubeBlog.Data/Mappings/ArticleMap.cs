using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.Parse("2E14C8CD-2E8F-4B9B-B1E4-9EB529BD0D32"),
                Title = "c# deneme makalesi 1",
                Content = "c# Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount = 0,
                CategoryId = Guid.Parse("CC60A0F7-934B-480C-A634-B019F8E57369"),
                ImageId = Guid.Parse("2FB21410-E80E-42BB-BA49-E07F16F9BF79"),
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            },
            new Article
            {
                Id = Guid.Parse("{2EA45A59-060F-404A-B458-6A45F95F57AC}"),
                Title = "Asp.net deneme makalesi 1",
                Content = "Asp.net Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount = 0,
                CategoryId = Guid.Parse("0EA2F85B-E76E-4BB0-9C2C-7E2DF1A5C113"),
                ImageId = Guid.Parse("0F6CFC4B-D2D4-4F85-BAB2-33891CAEF37E"),
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            }
            );


        }
    }
}
