using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Gameosoftv2.ServiceLayer
{
   public class AuthenticatedUserViewModel
    {
       public List<SelectListItem> Users { get; set; }
       public string UserId { get; set; }
       public string HoursPlayed { get; set; }

       public List<SelectListItem> Games { get; set; }
       public string GameId { get; set; }

       public List<UserGameViewModel> UserGames { get; set; }
    }

    public class UserGameViewModel
    {
        public string UserName { get; set; }
        public string GameName { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
        public TimeSpan HoursPlayed { get; set; }
    }
}
