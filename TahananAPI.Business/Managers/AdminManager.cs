using TahananAPI.Business.Interface;
using TahananAPI.Data.Interface;
using TahananAPI.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using StaticWebAPI.Business.Entities;
using System.Net;

namespace TahananAPI.Business.Managers
{
    public class AdminManager : IAdminManager
    {
        public IAdminRepository IAdminRepository;
        public AdminManager(IAdminRepository IAdminRepository)
        {
            this.IAdminRepository = IAdminRepository;
        }


        public IEnumerable<dynamic> GetAdmin()
        {
            try
            {
                return IAdminRepository.GetAdmin<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetAdminByID(object filter)
        {
            try
            {
                return IAdminRepository.GetAdminByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertAdmin(AdminEntity AdminEntity)
        {
            try
            {
                var filter = new
                {
                   RoleID = AdminEntity.RoleID,
                   AdminName = AdminEntity.AdminName,
                   AdminPassword= AdminEntity.AdminPassword,
                   Email = AdminEntity.Email,
                   PhoneNumber = AdminEntity.PhoneNumber,
                };
                return IAdminRepository.InsertAdmin(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateAdmin(AdminEntity AdminEntity)
        {
            try
            {
                var filter = new
                {
                    ID = AdminEntity.ID,
                    RoleID = AdminEntity.RoleID,
                    AdminName = AdminEntity.AdminName,
                    AdminPassword = AdminEntity.AdminPassword,
                    Email = AdminEntity.Email,
                    PhoneNumber = AdminEntity.PhoneNumber,
                };
                return IAdminRepository.UpdateAdmin(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteAdmin(object filter)
        {
            try
            {
                return IAdminRepository.DeleteAdmin(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetUsers()
        {
            try
            {
                return IAdminRepository.GetUsers<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetUsersByID(object filter)
        {
            try
            {
                return IAdminRepository.GetUsersByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertUsers(UsersEntity UsersEntity)
        {
            try
            {
                var filter = new
                {
                  RoleID = UsersEntity.RoleID,
                  UserName = UsersEntity.UserName,
                  UserPassword= UsersEntity.UserPassword,
                  PhoneNumber = UsersEntity.PhoneNumber,
                  Email = UsersEntity.Email,
                };
                return IAdminRepository.InsertUsers(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateUsers(UsersEntity UsersEntity)
        {
            try
            {
                var filter = new
                {
                    ID = UsersEntity.ID,
                    RoleID = UsersEntity.RoleID,
                    UserName = UsersEntity.UserName,
                    UserPassword = UsersEntity.UserPassword,
                    PhoneNumber = UsersEntity.PhoneNumber,
                    Email = UsersEntity.Email,
                };
                return IAdminRepository.UpdateUsers(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteUsers(object filter)
        {
            try
            {
                return IAdminRepository.DeleteUsers(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetProducts()
        {
            try
            {
                return IAdminRepository.GetProducts<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetProductsByID(object filter)
        {
            try
            {
                return IAdminRepository.GetProductsByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertProducts(ProductsEntity ProductsEntity)
        {
            try
            {
                var filter = new
                {
                    ProductName = ProductsEntity.ProductName,
                    Category= ProductsEntity.Category,
                    Price = ProductsEntity.Price,
                    Availablity = ProductsEntity.Availablity,
                    Description = ProductsEntity.Description,
                    Image = ProductsEntity.Image,

                };
                return IAdminRepository.InsertProducts(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateProducts(ProductsEntity ProductsEntity)
        {
            try
            {
                var filter = new
                {
                    ID = ProductsEntity.ID,
                    ProductName = ProductsEntity.ProductName,
                    Category = ProductsEntity.Category,
                    Price = ProductsEntity.Price,
                    Availablity = ProductsEntity.Availablity,
                    Description = ProductsEntity.Description,
                    Image = ProductsEntity.Image,
                };
                return IAdminRepository.UpdateProducts(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteProducts(object filter)
        {
            try
            {
                return IAdminRepository.DeleteProducts(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetBookings()
        {
            try
            {
                return IAdminRepository.GetBookings<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetBookingChart()
        {
            try
            {
                return IAdminRepository.GetBookingChart<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetBookingsByID(object filter)
        {
            try
            {
                return IAdminRepository.GetBookingsByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertBookings(BookingsEntity BookingsEntity)
        {
            try
            {
                var filter = new
                {
                    UserID = BookingsEntity.UserID,
                    BookingDate = BookingsEntity.BookingDate,
                    Products = BookingsEntity.Products,
                    Status = BookingsEntity.Status,
                    TotalAmount = BookingsEntity.TotalAmount,
                };
                return IAdminRepository.InsertBookings(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateBookings(BookingsEntity BookingsEntity)
        {
            try
            {
                var filter = new
                {
                    ID = BookingsEntity.ID,
                    UserID = BookingsEntity.UserID,
                    BookingDate = BookingsEntity.BookingDate,
                    Products = BookingsEntity.Products,
                    Status = BookingsEntity.Status,
                    TotalAmount = BookingsEntity.TotalAmount,
                };
                return IAdminRepository.UpdateBookings(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteBookings(object filter)
        {
            try
            {
                return IAdminRepository.DeleteBookings(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetRole()
        {
            try
            {
                return IAdminRepository.GetRole<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetRoleByID(object filter)
        {
            try
            {
                return IAdminRepository.GetRoleByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}