using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameosoftv2.BusinessLayer;
using System.Security.Claims;

namespace Gameosoftv2.DataLayer
{
    public class RegisterUserDataLayer : IRegisterUserDataLayer
    {
        //Original
        //public bool CreateUser(string userName, string passWord)
        //{
        //    var userStore = new UserStore<IdentityUser>();
        //    var manager = new UserManager<IdentityUser>(userStore);

        //    var user = new IdentityUser() { UserName = userName };
        //    IdentityResult result = manager.Create(user, passWord);
        //    return result.Succeeded;
        //}

        public RegisterUserBusinessModel CreateUser(RegisterUserBusinessModel RegisterUserBusinessModel)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser() { UserName = RegisterUserBusinessModel.UserName};
            IdentityResult result = manager.Create(user, RegisterUserBusinessModel.Password);
            ClaimsIdentity userIdentity = new ClaimsIdentity();
            if (result.Succeeded)
            {
               userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            }
            RegisterUserBusinessModel.IsRegisterUserSucceeded = result.Succeeded;

            return RegisterUserBusinessModel;
        }
    }
}
