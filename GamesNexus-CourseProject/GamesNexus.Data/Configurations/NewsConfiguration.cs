using GamesNexus.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Data.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder
               .Property(d => d.PublishedOn)
               .HasDefaultValue(DateTime.UtcNow);

            builder
                .HasData(GenerateNews());
        }

        private News[] GenerateNews()
        {
            ICollection<News> allNews = new HashSet<News>();

            News news;

            news = new News()
            {
                Id = 1,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            news = new News()
            {
                Id = 2,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum.",
                Content = "Lorem ipsum dolor, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            news = new News()
            {
                Id = 3,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            news = new News()
            {
                Id = 4,
                Title = "Lorem ipsum dolor sit amet. Phasellus ligula leo laoreet in odio. Phasellus elementum.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec interdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            news = new News()
            {
                Id = 5,
                Title = "Consectetur adipiscing elit. Phasellus ligula leo, pulvinar sed ullamcorper et, laoreet in odio. Phasellus elementum.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit. Malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis, ac porttitor nulla consectetur in. In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            news = new News()
            {
                Id = 6,
                Title = "Laoreet in odio. Phasellus elementum.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nterdum dictum pellentesque. In orci sem, iaculis a dolor vitae, pellentesque placerat odio. Vivamus tincidunt ex ipsum, eu elementum tortor scelerisque quis. Sed faucibus malesuada eros. Integer vitae imperdiet lectus. Ut fermentum placerat mi ut suscipit. Mauris nec viverra velit.Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla pulvinar lobortis turpis In id nibh sem. Donec ut semper sem. Phasellus pharetra faucibus sapien nec .",
                PublisherId = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B")
            };
            allNews.Add(news);

            return allNews.ToArray();
        }
    }
}
