using TahananAPI.Data.Interface;
using TahananAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahananAPI.Data.Interface;
using Dapper;
using System.Data;
namespace TahananAPI.Data.Repositories
{
    public class AdminRepository : Repository, IAdminRepository
    {


        public IEnumerable<dynamic> GetAdmin<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetAdmin]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetAdminByID<dynamic>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetAdminByID]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertAdmin(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_InsertAdmin]", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateAdmin(object filter)
        {
            try
            {

                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_UpdateAdmin]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_DeleteAdmin]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetUsers<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetUsers]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetUsersByID<dynamic>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetUsersByID]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertUsers(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_InsertUsers]", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateUsers(object filter)
        {
            try
            {

                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_UpdateUsers]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_DeleteUsers]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetProducts<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetProducts]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetProductsByID<dynamic>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetProductsByID]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertProducts(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_InsertProducts]", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateProducts(object filter)
        {
            try
            {

                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_UpdateProducts]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_DeleteProducts]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetBookings<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetBookings]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetBookingChart<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetBookingChart]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetBookingsByID<dynamic>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetBookingsByID]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertBookings(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_InsertBookings]", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateBookings(object filter)
        {
            try
            {

                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_UpdateBookings]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_DeleteBookings]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetRole<dynamic>()
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetRole]", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetRoleByID<dynamic>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<dynamic>("[dbo].[SProc_GetRoleByID]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }
}  


