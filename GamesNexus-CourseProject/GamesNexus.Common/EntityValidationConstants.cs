using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Common
{
    public static class EntityValidationConstants
    {
        public static class ApplicationUser
        {
            public const int UsernameMinLength = 3;
            public const int UsernameMaxLength = 20;
            public const string UsernameRegexPattern = @"^\w+$";

            public const int ApplicationUserFirstNameMinLength = 1;
            public const int ApplicationUserFirstNameMaxLength = 15;
            public const string ApplicationUserFirstNameRegexPattern = @"^[a-zA-Z]+$";

            public const int ApplicationUserLastNameMinLength = 1;
            public const int ApplicationUserLastNameMaxLength = 15;
            public const string ApplicationUserLastNameRegexPattern = @"^[a-zA-Z]+$";

            public const int ApplicationUserCountryMinLength = 4;
            public const int ApplicationUserCountryMaxLength = 60;
            public const string ApplicationUserCountryRegexPattern = @"^[a-zA-Z]+$";

            public const int ApplicationUserCityMinLength = 1;
            public const int ApplicationUserCityMaxLength = 190;
            public const string ApplicationUserCityRegexPattern = @"^[a-zA-Z]+$";

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;
        }

        public static class Category
        {
            public const int CategoryMinLength = 3;
            public const int CategoryMaxLength = 100;
        }

        public static class Comment
        {
            public const int CommentContentMinLength = 3;
            public const int CommentContentMaxLength = 2000;
        }

        public static class Discussion
        {
            public const int DiscussionTitleMinLength = 3;
            public const int DiscussionTitleMaxLength = 300;

            public const int DiscussionContentMinLength = 3;
            public const int DiscussionContentMaxLength = 2000;
        }
        public static class Game
        {
            public const int GameTitleMinLength = 3;
            public const int GameTitleMaxLength = 200;

            public const int GameDescriptionMaxLength = 500;

            public const int GameDeveloperMinLength = 2;
            public const int GameDeveloperMaxLength = 70;
        }

        public static class GameImage
        {
            public const int GameImageURLMaxLength = 2048;
        }

        public static class GameVideo
        {
            public const int GameVideoURLMaxLength = 2048;
        }

        public static class Genre
        {
            public const int GenreNameMinLength = 3;
            public const int GenreNameMaxLength = 100;
        }

        public static class News
        {
            public const int NewsTitleMinLength = 10;
            public const int NewsTitleMaxLength = 150;

            public const int NewsContentMinLength = 10;
            public const int NewsContentMaxLength = 650;
        }

        public static class Publisher
        {
            public const int PublisherEmailMinLength = 3;
            public const int PublisherEmailMaxLength = 320;

            public const int PublisherURLMaxLength = 2048;

            public const int PublisherCompanyNameMinLength = 3;
            public const int PublisherCompanyNameMaxLength = 60;
        }

        public static class Review
        {
            public const int ReviewCommentMinLength = 3;
            public const int ReviewCommentMaxLength = 1600;
        }
        public static class SystemRequirement
        {
            public const int GPUMinLength = 3;
            public const int GPUMaxLength = 150;

            public const int CPUMinLength = 3;
            public const int CPUMaxLength = 150;

            public const int OSMinLength = 3;
            public const int OSMaxLength = 100;

            public const int StorageMinLength = 1;
            public const int StorageMaxLength = 50;

            public const int RAMMinLength = 1;
            public const int RAMMaxLength = 150;

            public const int AdditionalNotesMinLength = 3;
            public const int AdditionalNotesMaxLength = 200;


        }

    }
}
