using GamesNexus.Web.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Discussion
{
    public class DiscussionDetailView
    {
        public DiscussionDetailView()
        {
            this.CreateCommentViewModel = new CreateCommentViewModel();
            this.Comments = new HashSet<CommentViewModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string PublishedOn { get; set; } = null!;

        public string PubisherBy { get; set; } = null!;

        public ICollection<CommentViewModel> Comments { get; set; }

        public CreateCommentViewModel CreateCommentViewModel { get; set; }
    }
}
