namespace GamesNexus.Web.ViewModels.Discussion
{
    public class AllDiscussionViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string PostedOn { get; set; } = null!;

        public int CommentCount { get; set; }
    }
}
