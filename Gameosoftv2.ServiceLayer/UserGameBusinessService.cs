using Gameosoftv2.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.ServiceLayer
{
    public class UserGameBusinessService
    {
        private Gameosoftv2.BusinessLayer.UserGameBusinessService _userGameBusinessService;
        public UserGameBusinessService(Gameosoftv2.BusinessLayer.UserGameBusinessService userGameBusinessService)
        {
            _userGameBusinessService = userGameBusinessService;
        }
        public void insert(UserGameBusinessModel userGameBusinessModel)
        {
            _userGameBusinessService.Insert(userGameBusinessModel);
        }
    }
}
