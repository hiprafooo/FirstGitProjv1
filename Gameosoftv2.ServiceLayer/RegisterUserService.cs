using Gameosoftv2.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.ServiceLayer
{
    public class RegisterUserService
    {
        private Gameosoftv2.BusinessLayer.RegisterUserService _registerUserService;
        public RegisterUserService(Gameosoftv2.BusinessLayer.RegisterUserService registerUserService)
        {
            _registerUserService = registerUserService;
        }

        public RegisterUserViewModel RegisterUser(RegisterUserViewModel registerUserViewModel)
        {
            RegisterUserBusinessModel RegisterUserBusinessModel = new BusinessLayer.RegisterUserBusinessModel()
            {
                Password = registerUserViewModel.Password,
                UserName = registerUserViewModel.UserName
            };
            RegisterUserBusinessModel = _registerUserService.RegisterUser(RegisterUserBusinessModel);
            registerUserViewModel.IsRegisterUserSucceeded = RegisterUserBusinessModel.IsRegisterUserSucceeded;
            registerUserViewModel.ClaimsIdentity = RegisterUserBusinessModel.ClaimsIdentity;
            return registerUserViewModel;
        }
    }
}
