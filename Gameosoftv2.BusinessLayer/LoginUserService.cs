using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public class LoginUserService
    {
        public ILoginUserDataLayer LoginUserDataLayer { get; set; }
        public LoginUserService(ILoginUserDataLayer loginUserDataLayer)
        {
            LoginUserDataLayer = loginUserDataLayer;
        }
        public LoginUserBusinessModel LoginUser(LoginUserBusinessModel LoginUserBusinessModel)
        {
            LoginUserBusinessModel = LoginUserDataLayer.LoginUser(LoginUserBusinessModel);
            return LoginUserBusinessModel;
        }
    }
}
