using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameosoftv2.BusinessLayer
{
    public interface ILoginUserDataLayer
    {
        LoginUserBusinessModel LoginUser(LoginUserBusinessModel loginUserBusinessModel);
    }
}
