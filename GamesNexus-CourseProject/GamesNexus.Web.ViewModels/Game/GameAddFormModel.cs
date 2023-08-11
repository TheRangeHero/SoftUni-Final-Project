using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Game
{
    public class GameAddFormModel
    {
        public long Id { get; set; }


        public string Title { get; set; } = null!;


        public string Description { get; set; } = null!;


        public decimal Price { get; set; }

        public string Developer { get; set; } = null!;
    }
}
