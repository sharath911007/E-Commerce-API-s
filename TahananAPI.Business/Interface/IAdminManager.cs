using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticWebAPI.Business.Entities;

namespace TahananAPI.Business.Interface
{
    public interface IAdminManager
    {
        IEnumerable<dynamic> GetAdmin();
        IEnumerable<dynamic> GetAdminByID(object filter);
        Int64 InsertAdmin(AdminEntity AdminEntity);
        Int64 UpdateAdmin(AdminEntity AdminEntity);
        Int64 DeleteAdmin(object filter);

        IEnumerable<dynamic> GetUsers();
        IEnumerable<dynamic> GetUsersByID(object filter);
        Int64 InsertUsers(UsersEntity UsersEntity);
        Int64 UpdateUsers(UsersEntity UsersEntity);
        Int64 DeleteUsers(object filter);

        IEnumerable<dynamic> GetProducts();
        IEnumerable<dynamic> GetProductsByID(object filter);
        Int64 InsertProducts(ProductsEntity ProductsEntity);
        Int64 UpdateProducts(ProductsEntity ProductsEntity);
        Int64 DeleteProducts(object filter);

        IEnumerable<dynamic> GetBookings();
        IEnumerable<dynamic> GetBookingChart();
        IEnumerable<dynamic> GetBookingsByID(object filter);
        Int64 InsertBookings(BookingsEntity BookingsEntity);
        Int64 UpdateBookings(BookingsEntity BookingsEntity);
        Int64 DeleteBookings(object filter);

        IEnumerable<dynamic> GetRole();
        IEnumerable<dynamic> GetRoleByID(object filter);



    }

}
