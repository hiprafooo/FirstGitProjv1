using Gameosoftv2.BusinessLayer;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.DataLayer
{
    public class LoginUserDataLayer : ILoginUserDataLayer
    {
       public LoginUserBusinessModel LoginUser(LoginUserBusinessModel loginUserBusinessModel)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(loginUserBusinessModel.UserName, loginUserBusinessModel.Password);
            loginUserBusinessModel.IsUserLoginSucceeded = user != null;
            return loginUserBusinessModel;
        }
    }
}
