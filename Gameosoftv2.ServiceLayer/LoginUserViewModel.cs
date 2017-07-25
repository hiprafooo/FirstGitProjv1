using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.ServiceLayer
{
    public class LoginUserViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsUserLoginSucceeded { get; set; }
    }
}