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
            public const int ApplicationUserPasswordMinLength = 6;
            public const int ApplicationUserPasswordMaxLength = 100;

            public const int ApplicationUserFirstNameMinLength = 1;
            public const int ApplicationUserFirstNameMaxLength = 15;

            public const int ApplicationUserLastNameMinLength = 1;
            public const int ApplicationUserLastNameMaxLength = 15;

            public const int ApplicationUserAvatarURLMaxLenght = 2048;

            public const int ApplicationUserCountryMinLenght = 4;
            public const int ApplicationUserCountryMaxLenght = 60;


            public const int ApplicationUserStateCityMaxLenght = 1;
            public const int ApplicationUserStateCityMinLenght = 190;
        }

        public static class Category
        {
            public const int CategoryMinLenght = 3;
            public const int CategoryMaxLenght = 100;
        }

        public static class Comment
        {
            public const int CommentContentMinLenght = 3;
            public const int CommentContentMaxLenght = 2000;
        }

        public static class Discussion
        {
            public const int DiscussionTitleMinLenght = 3;
            public const int DiscussionTitleMaxLenght = 300;

            public const int DiscussionContentMinLenght = 3;
            public const int DiscussionContentMaxLenght = 2000;
        }
        public static class Game
        {
            public const int GameTitleMinLenght = 3;
            public const int GameTitleMaxLenght = 200;

            public const int GameDescriptionMaxLenght = 500;

            public const int GameDeveloperMinLenght = 2;
            public const int GameDeveloperMaxLenght = 70;
        }

        public static class GameImage
        {
            public const int GameImageURLMaxLenght = 2048;
        }

        public static class GameVideo
        {
            public const int GameVideoURLMaxLenght = 2048;
        }

        public static class Genre
        {
            public const int GenreNameMinLenght = 3;
            public const int GenreNameMaxLenght = 100;
        }

        public static class News
        {
            public const int NewsTitleMinLegth = 10;
            public const int NewsTitleMaxLegth = 150;

            public const int NewsContentMinLength = 10;
            public const int NewsContentMaxLength = 650;
        }

        public static class Publisher
        {
            public const int PublisherEmailMinLength = 3;
            public const int PublisherEmailMaxLength = 320;

            public const int PublisherURLMaxLength = 2048;
        }

        public static class Review
        {


            public const int ReviewCommentMinLenght = 3;
            public const int ReviewCommentMaxLenght = 100;
        }
        public static class SystemRequirement
        {
            public const int GPUMinLenght = 3;
            public const int GPUMaxLenght = 30;

            public const int CPUMinLenght = 1;
            public const int CPUMaxLenght = 50;

            public const int OSMinLenght = 3;
            public const int OSMaxLenght = 50;

        }

    }
}
