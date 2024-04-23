using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICoreBL.Generic
{
    public interface IMUserStore
    {
        MUser SignIn(MUser user);
        void SignUp(MUser user);
        List<MUser> getAllUsers();
    }
}
