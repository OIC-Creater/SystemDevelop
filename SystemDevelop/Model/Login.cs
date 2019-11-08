using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDevelop.Model.DB;

namespace SystemDevelop.Model
{
    class Login
    {
        private DbCreate dbCreate = new DbCreate();
        public Login()
        {
            dbCreate.ConnectDb();
        }
    }
}
