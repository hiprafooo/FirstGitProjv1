using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public class RegisterUserBusinessModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRegisterUserSucceeded { get; set; }
        public ClaimsIdentity ClaimsIdentity { get; set; }
    }
}
