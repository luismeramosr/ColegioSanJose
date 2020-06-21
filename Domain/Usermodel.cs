using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_interface;

namespace Domain
{
    public class Usermodel
    {
        UserDat userdat = new UserDat();
        public bool LoginUser(string dni, string pass)
        {
            return userdat.Login(dni, pass);
        }
    }
}
