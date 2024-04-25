using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Models
{
    public class UserHandler
    {
        public Registraion GetUsers(string LoginId, string password)
        {
            using (Database context = new Database())
            {

                return (from s in context.Registraions
                        .Include("RoleManagement")
                        where s.LoginId.Equals(LoginId) && s.Password.Equals(password)
                        select s).FirstOrDefault();






            }
        }
    }
}
