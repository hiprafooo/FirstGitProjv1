using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public class UserGameBusinessService
    {
        private IUserGameDataLayer UserGameDataLayer { get; set; }
        public UserGameBusinessService(IUserGameDataLayer userGameDataLayer)
        {
            UserGameDataLayer = userGameDataLayer;
        }
        public void Insert(UserGameBusinessModel UserGameBusinessModel)
        {
            UserGameDataLayer.Insert(UserGameBusinessModel);
        }
    }
}
