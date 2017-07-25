using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public class UserGameBusinessModel
    {
        public int UserGameId { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public TimeSpan HoursPlayed { get; set; }
    }
}
