using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Comment;
using GamesNexus.Web.ViewModels.Discussion;
using Microsoft.EntityFrameworkCore;


namespace GamesNexus.Services.Data
{
    public class DiscussionServices : IDiscussionService
    {
        private readonly IRepository repository;

        public DiscussionServices(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<AllDiscussionViewModel>> AllAsync()
        {
            return await this.repository.AllReadonly<Discussion>()
                .Where(d=>d.IsActive)
                .Select(d => new AllDiscussionViewModel()
                {
                    Id = d.Id,
                    Title = d.Title,
                    CommentCount = d.Comments.Count(),
                }).ToArrayAsync();
        }


        public async Task<DiscussionDetailView> GetDiscussionByIdAsync(int id)
        {
            Discussion discussion = await this.repository.AllReadonly<Discussion>()
                .Include(c => c.Comments)
                .ThenInclude(u => u.ApplicationUser)
                .Include(d=>d.ApplicationUser)
                .FirstAsync(d => d.Id == id);

            return new DiscussionDetailView
            {
                Id = discussion.Id,
                Content = discussion.Content,
                Title = discussion.Title,
                PubisherBy = discussion.ApplicationUser.UserName,
                PublishedOn= discussion.CreatedOn.ToString("dd.MM.yyyy"),
                Comments = discussion.Comments
                .OrderBy(c => c.PostedOn)
                .Select(c => new CommentViewModel()
                {
                    Id = c.Id,
                    Content = c.Content,
                    PublishedBy = c.ApplicationUser.UserName,
                    PostedOn = c.PostedOn.ToString("dd.MM.yyyy")
                }).ToList()
            };


        }
        public async Task<int> CreateAsync(DiscussionCreateViewModel model, string userId)
        {
            var discussion = new Discussion
            {
                Title = model.Title,
                Content = model.Content,
                ApplicationUserId = Guid.Parse(userId)
            };

            await this.repository.AddAsync(discussion);
            await this.repository.SaveChangesAsync();

            return discussion.Id;
        }

        public async Task<bool> DiscussionExistsByIdAsync(int id)
        {
            bool result = await this.repository.AllReadonly<Discussion>()
               .Where(d => d.IsActive)
               .AnyAsync(d => d.Id == id);

            return result;
        }

        public async Task DeleteDiscussionByIdAsync(int id)
        {
            Discussion discussionToDelete = await this.repository.GetByIdAsync<Discussion>(id);
            discussionToDelete.IsActive = false;
            await this.repository.SaveChangesAsync();
        }

        public async Task<bool> IsUserWithIdPublisherOfDiscussionWithIdAsync(int disccussonId, string userId)
        {
            Discussion news = await this.repository.AllReadonly<Discussion>()
                .Where(d => d.IsActive)
            .FirstAsync(d => d.Id == disccussonId);

            return news.ApplicationUserId.ToString() == userId;
        }
    }
}
