using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahananAPI.Data.Interface
{
    public interface IAdminRepository 
    {

        IEnumerable<dynamic> GetAdmin<dynamic>();
        IEnumerable<dynamic> GetAdminByID<dynamic>(object filter);
        Int64 InsertAdmin(object filter);
        Int64 UpdateAdmin(object filter);
        Int64 DeleteAdmin(object filter);

        IEnumerable<dynamic> GetUsers<dynamic>();
        IEnumerable<dynamic> GetUsersByID<dynamic>(object filter);
        Int64 InsertUsers(object filter);
        Int64 UpdateUsers(object filter);
        Int64 DeleteUsers(object filter);

        IEnumerable<dynamic> GetProducts<dynamic>();
        IEnumerable<dynamic> GetProductsByID<dynamic>(object filter);
        Int64 InsertProducts(object filter);
        Int64 UpdateProducts(object filter);
        Int64 DeleteProducts(object filter);


        IEnumerable<dynamic> GetBookings<dynamic>();
        IEnumerable<dynamic> GetBookingChart<dynamic>();
        IEnumerable<dynamic> GetBookingsByID<dynamic>(object filter);
        Int64 InsertBookings(object filter);
        Int64 UpdateBookings(object filter);
        Int64 DeleteBookings(object filter);

        IEnumerable<dynamic> GetRole<dynamic>();
        IEnumerable<dynamic> GetRoleByID<dynamic>(object filter);


    }
}
