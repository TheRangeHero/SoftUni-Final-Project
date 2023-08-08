using GamesNexus.Data.Models;
using GamesNexus.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesNexus.Data.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .Property(d => d.PostedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder
                .Property(d => d.Rating)
                .HasDefaultValue(RatingOption.None);

            builder.HasData(GenerateReviews());
        }

        private Review[] GenerateReviews()
        {
            ICollection<Review> reviews = new HashSet<Review>();

            Review review;
            review = new Review()
            {
                Id = 1,
                Rating = RatingOption.Good,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer suscipit porttitor dolor vel sagittis. Integer vulputate fringilla finibus. Morbi vel.",
                ApplicationUserId = Guid.Parse("875B63F6-4C14-4757-BBC5-149615044A6F"),
                GameId = 1
            };
            reviews.Add(review);

            review = new Review()
            {
                Id = 2,
                Rating = RatingOption.Bad,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed varius tempor sapien at rhoncus. Donec finibus lacinia eros at iaculis. Praesent tincidunt dui lorem, in convallis urna varius vel. Etiam vehicula eros finibus sapien tincidunt, at luctus sem tristique. Aenean quis eros lobortis est tempus porta. Phasellus sed dui in neque hendrerit tempor eu a turpis. Sed blandit mi eget magna eleifend commodo. Phasellus cursus purus a mi eleifend vehicula. In aliquam leo eu suscipit interdum. Aliquam quis ipsum in urna tristique viverra a et lectus. Vivamus metus nulla, cursus sit amet augue ac, egestas rutrum enim. Donec accumsan ante.",
                ApplicationUserId = Guid.Parse("6661D94A-5775-4B00-8970-EAC777ADDE4A"),
                GameId = 1
            };
            reviews.Add(review);

            review = new Review()
            {
                Id = 3,
                Rating = RatingOption.Bad,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dictum, diam quis lobortis facilisis, neque nisi pulvinar eros, ac porta lectus velit eu lacus. Sed posuere sapien vitae magna imperdiet, scelerisque tempor mi condimentum. Aliquam erat volutpat. Cras dolor elit, pharetra sit amet tristique vitae.",
                ApplicationUserId = Guid.Parse("C1D42AEB-76E5-42DA-80A3-53BAFD365D4C"),
                GameId = 1
            };
            reviews.Add(review);

            review = new Review()
            {
                Id = 4,
                Rating = RatingOption.Good,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dictum, diam quis lobortis facilisis, neque nisi pulvinar eros, ac porta lectus velit eu lacus. Sed posuere sapien vitae magna imperdiet, scelerisque tempor mi condimentum. Aliquam erat volutpat. Cras dolor elit, pharetra sit amet tristique vitae.",
                ApplicationUserId = Guid.Parse("875B63F6-4C14-4757-BBC5-149615044A6F"),
                GameId = 2
            };
            reviews.Add(review);

            review = new Review()
            {
                Id = 5,
                Rating = RatingOption.Good,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris molestie et nisi nec tempus. Fusce quis aliquet nisl. Nullam volutpat, sapien et accumsan vulputate, leo ligula convallis nulla, id hendrerit dolor tortor quis odio. Aenean pellentesque sagittis lacinia. Sed accumsan porttitor leo, sit amet ullamcorper sem molestie nec. Aenean maximus a diam at mattis. Donec in velit pellentesque mauris pretium fringilla ut ac erat.Etiam facilisis sapien sapien, et finibus sapien pretium id. Duis congue magna a lectus accumsan, sed ullamcorper leo tempor. Vestibulum vel efficitur magna, feugiat venenatis turpis. Etiam vulputate eros quis purus commodo auctor ut quis felis. Cras mollis tristique massa, sit amet semper elit varius eget. Donec eget diam id tortor aliquam sollicitudin ut nec ligula. Donec hendrerit augue id tortor iaculis bibendum. Aenean vulputate ante ut tincidunt aliquam.Donec vitae lacinia nisl, at sollicitudin metus. Sed pellentesque imperdiet eleifend. Integer scelerisque viverra nisl, ac imperdiet magna aliquam vel. Quisque in convallis dui. Pellentesque feugiat justo vitae mauris suscipit, sed malesuada tortor dapibus. Proin nec est aliquam, vulputate lectus sed, tristique velit. Maecenas quam orci, euismod at ultrices ac, pulvinar sed massa. Ut iaculis malesuada turpis quis elementum. Nam vel dapibus nunc, vel ultricies ipsum. In.",
                ApplicationUserId = Guid.Parse("A7BF8C32-C790-4408-8464-0B3A2D986FA1"),
                GameId = 3
            };
            reviews.Add(review);

            review = new Review()
            {
                Id = 6,
                Rating = RatingOption.Bad,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dapibus consequat eros eu sodales. Sed vel enim et risus tempor dignissim non et sem. Phasellus suscipit mi nibh, at ultricies odio blandit a. Cras posuere, ante sed egestas pretium, leo erat ullamcorper nisi, et condimentum ligula ligula vitae urna. Proin vel nunc iaculis, ornare libero et, mollis quam. Maecenas eu dui odio. Morbi mi mauris, consectetur vel est in, iaculis elementum sapien. Nulla luctus bibendum nisl, in pellentesque dolor. Ut.",
                ApplicationUserId = Guid.Parse("875B63F6-4C14-4757-BBC5-149615044A6F"),
                GameId = 3
            };
            reviews.Add(review);

            return reviews.ToArray();
        }
    }
}
