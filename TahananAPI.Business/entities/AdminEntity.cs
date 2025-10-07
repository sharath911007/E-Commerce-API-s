using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebAPI.Business.Entities
{
    public class AdminEntity
    {
        public Int64 ID { get; set; }
        public Int64 RoleID { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
