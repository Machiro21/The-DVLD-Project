using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLD_My_Version_DataAccessLayer;

namespace DVLD_My_Version_BusinessLayer
{
    public class clsUsers
    {
        private string _UserName { get; set; }
        private string _Password { get; set; }

        public static bool CheckUserNameAndPassowrd(string Username, string Password)
        {
            if (clsUserDataAccesscs.CheckUserNameAndPassword(Username, Password))
                return true;
            else
                return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccesscs.GetAllUsers();
        }


    }
}
