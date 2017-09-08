using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.User.Model.ViewModel
{
    public class VMUser
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; }

        public string Portrait { get; set; }

        public string Password { get; set; }

        public int HierachyID { get; set; }

        public string HierachyName { get; set; }

        //public int GroupID { get; set; }
        //public int GroupLevel { get; set; }
        public bool IsSuperAdmin { get; set; }


        public List<string> RoleNames { get; set; }

        public List<int> Roles { get; set; }

        public List<int> Customers { get; set; }
        
    }
}