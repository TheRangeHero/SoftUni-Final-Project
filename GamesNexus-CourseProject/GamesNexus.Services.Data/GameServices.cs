using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.ViewModels.Game;
using GamesNexus.Web.ViewModels.SystemRequirement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Services.Data
{
    public class GameServices : IGameService
    {
        private readonly IRepository repository;
      

        public GameServices(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<GameAllViewModel>> AllAsync()
        {
            IEnumerable<GameAllViewModel> allGames = await repository.AllReadonly<Game>()               
                .Include(g=>g.Images)               
                .Select(g=> new GameAllViewModel
                {
                    Title = g.Title,
                    Image = g.Images.FirstOrDefault().ImageUrl,
                    Price = g.Price,
                
                }).ToArrayAsync();

            return allGames;

        }
    }
}
