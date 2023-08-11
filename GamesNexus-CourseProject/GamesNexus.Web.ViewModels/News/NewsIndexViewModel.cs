using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.News
{
    public class NewsIndexViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        //public string Content { get; set; } = null!;

        public string PublishedOn { get; set; } = null!;


    }
}
