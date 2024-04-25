using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Models
{
    public class Registraion
    {
        public int Id  { get; set; }
        public string LoginId   { get; set; }
        public string FullName   { get; set; }

        public string  Password  { get; set; }

        public virtual RoleManagement RoleManagement { get; set; }

        public bool Rememberme { get; set; }
        

    }
}
