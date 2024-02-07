using Piggy.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy
{
    public static class Session
    {
        public static UserModel CurrentUser;
        static bool needTableReload = false;
    }

}
