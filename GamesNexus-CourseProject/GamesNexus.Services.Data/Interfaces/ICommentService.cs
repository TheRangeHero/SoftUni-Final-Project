using GamesNexus.Data.Models;
using GamesNexus.Web.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data.Interfaces
{
    public interface ICommentService
    {     
        Task<int?> AddCommentToDiscussionAsync(int discussionId, string userId,CreateCommentViewModel model);
        
    }
}
