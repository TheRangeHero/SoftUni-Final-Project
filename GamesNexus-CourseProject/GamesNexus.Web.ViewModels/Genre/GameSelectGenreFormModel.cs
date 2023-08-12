using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Genre
{
    public class GameSelectGenreFormModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsSelected { get; set; }
    }
}
