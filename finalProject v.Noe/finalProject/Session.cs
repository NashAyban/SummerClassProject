using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagement;

namespace sessionManager
{
    public static class Session
    {
        //a session to store the currentl logged in user
        public static User CurrentUser { get; set; }
    }
}
