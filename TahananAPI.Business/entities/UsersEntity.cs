using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebAPI.Business.Entities
{
    public class UsersEntity
    {
        public Int64 ID { get; set; }
        public Int64 RoleID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
