using Gameosoftv2.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.DataLayer
{
    public class UserGameDataLayer : IUserGameDataLayer
    {
        public void Insert(UserGameBusinessModel userGameBusinessModel)
        {
            UserGame UserGame = new UserGame
            {
                GameId = userGameBusinessModel.GameId,
                UserId = userGameBusinessModel.UserId,
                HoursPlayed = userGameBusinessModel.HoursPlayed
            };
            using (var dbCtx = new ApplicationDbContext())
            {
                dbCtx.UserGame.Add(UserGame);
                dbCtx.SaveChanges();
            }
        }
    }
}
