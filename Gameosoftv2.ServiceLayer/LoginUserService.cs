using Gameosoftv2.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.ServiceLayer
{
    public class LoginUserService
    {
        private Gameosoftv2.BusinessLayer.LoginUserService _LoginUserService {get;set;}
        public LoginUserService(Gameosoftv2.BusinessLayer.LoginUserService loginUserService)
        {
            _LoginUserService = loginUserService;
        }
        public LoginUserViewModel LoginUser(LoginUserViewModel loginUserViewModel)
        {
            LoginUserBusinessModel LoginUserBusinessModel = new LoginUserBusinessModel
            {
                Password = loginUserViewModel.Password,
                UserName = loginUserViewModel.UserName
            };
            LoginUserBusinessModel = _LoginUserService.LoginUser(LoginUserBusinessModel);
            loginUserViewModel.IsUserLoginSucceeded = LoginUserBusinessModel.IsUserLoginSucceeded;
            return loginUserViewModel;
        }
    }
}
