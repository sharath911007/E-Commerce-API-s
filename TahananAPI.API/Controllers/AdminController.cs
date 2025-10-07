using log4net;
using TahananAPI.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using StaticWebAPI.Business.Entities;
using Org.BouncyCastle.Asn1.Ocsp;

namespace sharath.API.Controllers
{
    public class AdminController : ApiController
    {
        public IAdminManager IAdminManager;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public AdminController(IAdminManager IAdminManager)
        {
            this.IAdminManager = IAdminManager;
        }

        [HttpGet]
        [Route("Admin/GetAdmin")]
        public HttpResponseMessage GetAdmin()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetAdmin();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetAdmin in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Admin/GetAdminByID")]
        public HttpResponseMessage GetAdminByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                object res = IAdminManager.GetAdminByID(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetAdminByID in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Admin/InsertAdmin")]
        public HttpResponseMessage InsertAdmin(AdminEntity AdminEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.InsertAdmin(AdminEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/InsertAdmin :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/InsertAdmin ");
            }
            return response;
        }

        [HttpPost]
        [Route("Admin/UpdateAdmin")]
        public HttpResponseMessage UpdateAdmin(AdminEntity AdminEntity)

        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.UpdateAdmin(AdminEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/UpdateAdmin :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/UpdateAdmin");
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/DeleteAdmin")]
        public HttpResponseMessage DeleteAdmin(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                Int64 res = IAdminManager.DeleteAdmin(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteAdmin + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Admin/GetUsers")]
        public HttpResponseMessage GetUsers()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetUsers();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetUsers in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Admin/GetUsersByID")]
        public HttpResponseMessage GetUsersByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                object res = IAdminManager.GetUsersByID(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetUsersByID in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Admin/InsertUsers")]
        public HttpResponseMessage InsertUsers(UsersEntity UsersEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.InsertUsers(UsersEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/InsertUsers :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/InsertUsers ");
            }
            return response;
        }

        [HttpPost]
        [Route("Admin/UpdateUsers")]
        public HttpResponseMessage UpdateUsers(UsersEntity UsersEntity)

        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.UpdateUsers(UsersEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/UpdateUsers :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/UpdateUsers");
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/DeleteUsers")]
        public HttpResponseMessage DeleteUsers(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                Int64 res = IAdminManager.DeleteUsers(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteUsers + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/GetProducts")]
        public HttpResponseMessage GetProducts()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetProducts();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetProducts in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Admin/GetProductsByID")]
        public HttpResponseMessage GetProductsByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                object res = IAdminManager.GetProductsByID(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetProductsByID in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Admin/InsertProducts")]
        public HttpResponseMessage InsertProducts(ProductsEntity ProductsEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.InsertProducts(ProductsEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/InsertProducts :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/InsertProducts ");
            }
            return response;
        }

        [HttpPost]
        [Route("Admin/UpdateProducts")]
        public HttpResponseMessage UpdateProducts(ProductsEntity ProductsEntity)

        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.UpdateProducts(ProductsEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/UpdateProducts :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/UpdateAdmin");
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/DeleteProducts")]
        public HttpResponseMessage DeleteProducts(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                Int64 res = IAdminManager.DeleteProducts(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteProducts + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Admin/GetBookings")]
        public HttpResponseMessage GetBookings()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetBookings();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetBookings in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Admin/GetBookingChart")]
        public HttpResponseMessage GetBookingChart()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetBookingChart();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetBookingChart in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/GetBookingsByID")]
        public HttpResponseMessage GetBookingsByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                object res = IAdminManager.GetBookingsByID(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetBookingsByID in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Admin/InsertBookings")]
        public HttpResponseMessage InsertBookings(BookingsEntity BookingsEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.InsertBookings(BookingsEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/InsertBookings :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/InsertBookings ");
            }
            return response;
        }

        [HttpPost]
        [Route("Admin/UpdateBookings")]
        public HttpResponseMessage UpdateBookings(BookingsEntity BookingsEntity)

        {
            HttpResponseMessage response;
            try
            {
                Int64 Result = IAdminManager.UpdateBookings(BookingsEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Admin/UpdateBookings :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Admin/UpdateBookings");
            }
            return response;
        }


        [HttpGet]
        [Route("Admin/DeleteBookings")]
        public HttpResponseMessage DeleteBookings(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                Int64 res = IAdminManager.DeleteBookings(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteBookings + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Admin/GetRole")]
        public HttpResponseMessage GetRole()
        {
            HttpResponseMessage response;
            try
            {
                object res = IAdminManager.GetRole();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetRole in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Admin/GetRoleByID")]
        public HttpResponseMessage GetRoleByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new
                {
                    ID = ID
                };
                object res = IAdminManager.GetRoleByID(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetRoleByID in Admin Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


         }
}


