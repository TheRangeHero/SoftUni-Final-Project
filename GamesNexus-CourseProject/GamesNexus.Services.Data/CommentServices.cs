using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Comment;

namespace GamesNexus.Services.Data
{
    public class CommentServices : ICommentService
    {
        private readonly IRepository repository;

        public CommentServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<int?> AddCommentToDiscussionAsync(int discussionId, string userId, CreateCommentViewModel model)
        {
            var newComment = new Comment()
            {
                DiscussionId = discussionId,
                Content = model.Content,
                ApplicationUserId = Guid.Parse(userId)
            };

            await this.repository.AddAsync(newComment);
            await this.repository.SaveChangesAsync();

            return newComment.Id;
        }
    }
}
