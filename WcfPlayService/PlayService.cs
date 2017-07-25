using Gameosoftv2.BusinessLayer;
using Gameosoftv2.DataLayer;
using Gameosoftv2.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfPlayService
{
    public class PlayService : IPlayService
    {
        public void InsertUserGameRecord(int GameId, string UserId, string HoursPlayed)
        {
            UserGameBusinessModel UserGame = new UserGameBusinessModel
            {
                GameId = GameId,
                UserId = UserId,
                HoursPlayed = TimeSpan.Parse(HoursPlayed)
            };

            IUserGameDataLayer userGameDataLayer = new UserGameDataLayer();

            Gameosoftv2.BusinessLayer.UserGameBusinessService UserGameBusinessService = new Gameosoftv2.BusinessLayer.UserGameBusinessService(userGameDataLayer);
            Gameosoftv2.ServiceLayer.UserGameBusinessService UserGameBusiness = new Gameosoftv2.ServiceLayer.UserGameBusinessService(UserGameBusinessService);
            UserGameBusiness.insert(UserGame);


        }
    }
}
