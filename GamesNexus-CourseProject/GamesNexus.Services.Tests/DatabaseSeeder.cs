using GamesNexus.Data;
using GamesNexus.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Tests
{
    public static class DatabaseSeeder
    {
        public static ApplicationUser PublisherUser;
        public static ApplicationUser NormalUser;
        public static Publisher Publisher;


        public static void SeedDatabase(GamesNexusDbContext dbContext)
        {
           

            NormalUser = new ApplicationUser()
            {
                UserName = "Therangehero",
                NormalizedEmail = "THERANGEHERO",
                Email = "TheRangeHeroUser@users.com",
                NormalizedUserName = "THERANGEHEROUSER@USERS.COM",
                EmailConfirmed = false,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "0ab8458e-be8a-4ca8-8d34-6e54ceba475c",
                ConcurrencyStamp = "c57bcf89-19dc-4ff6-8983-a386e59fee84",
                TwoFactorEnabled = false,
                FirstName = "Misho",
                LastName = "Stanchevvvv",
                Country = "Bulgaria",
                City = "Varna"
            };

            PublisherUser = new ApplicationUser()
            {

                UserName = "TheRangeHeroPublisher@publishers.com",
                NormalizedEmail = "THERANGEHEROPUBLISHER@PUBLISHERS.COM",
                Email = "TheRangeHeroPublisher@publishers.com",
                NormalizedUserName = "THERANGEHEROPUBLISHER@PUBLISHERS.COM",
                EmailConfirmed = false,
                PasswordHash = "5f395d07369071a505ef926527de2ac53e8c29e103dc63398315bc276224b81a",
                SecurityStamp = "259245e2-7f7b-4bb8-8981-a00537eb1bd1",
                ConcurrencyStamp = "f4769e41-f48e-44bb-b940-97ef4577f6f7",
                TwoFactorEnabled = false,               
            };
            Publisher = new Publisher()
            {
                Id = Guid.Parse("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B"),
                ApplicationUser = PublisherUser,
                BusinessEmail = "TheRangeHeroPublisher@publish.com",
                WebsiteURL = "https://example.org/apparel",
                CompanyName = "TheCreator"
            };


            dbContext.Users.Add(PublisherUser);
            dbContext.Users.Add(NormalUser);
            dbContext.Publishers.Add(Publisher);

            dbContext.SaveChanges();


        }
    }
}
