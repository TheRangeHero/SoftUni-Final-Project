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
    public class GameVideoConfiguration : IEntityTypeConfiguration<GameVideo>
    {
        public void Configure(EntityTypeBuilder<GameVideo> builder)
        {
            builder.HasData(GenerateGameVideos());
        }

        private GameVideo[] GenerateGameVideos()
        {
            ICollection<GameVideo> gameVideos = new HashSet<GameVideo>();

            GameVideo gameVideo;
            gameVideo = new GameVideo()
            {
                Id = 1,
                VideoUrl = "https://www.leagueoflegends.com/static/hero-0632cbf2872c5cc0dffa93d2ae8a29e8.webm",
                GameId = 1,
            };
            gameVideos.Add(gameVideo);

            gameVideo = new GameVideo()
            {
                Id = 2,
                VideoUrl = "https://cdn.akamai.steamstatic.com/steam/apps/256752581/movie480.webm?t=1560272971",
                GameId = 2,
            };
            gameVideos.Add(gameVideo);

            gameVideo = new GameVideo()
            {
                Id = 3,
                VideoUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/81958/movie480.webm?t=1554409259",
                GameId = 3,
            };
            gameVideos.Add(gameVideo);

            return gameVideos.ToArray();
        }
    }
}
