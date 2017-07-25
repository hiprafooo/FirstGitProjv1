using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public class RegisterUserService
    {
        public IRegisterUserDataLayer RegisterUserDataLayer { get; set; }
        public RegisterUserService(IRegisterUserDataLayer registerUserDataLayer)
        {
            RegisterUserDataLayer = registerUserDataLayer;
        }

        public RegisterUserBusinessModel RegisterUser(RegisterUserBusinessModel registerUser)
        {
            return RegisterUserDataLayer.CreateUser(registerUser);
        }
    }
}
