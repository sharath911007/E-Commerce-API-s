using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebAPI.Business.Entities
{
    public  class BookingsEntity
    {
        public Int64 ID { get; set; }
        public Int64 UserID { get; set; }
        public string BookingDate { get; set; }
        public string Products { get; set; }
        public string Status { get; set; }
        public string TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
    }
}
