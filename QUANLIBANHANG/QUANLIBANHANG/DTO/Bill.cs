using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Bill
    {


        private DateTime? checkInDate;
        private DateTime? checkOutDate;
        private int status;
        private int id;
        
        public Bill(DataRow row)
        {
            this.id = (int)row["ID"];
            this.checkInDate = (DateTime?)row["DATECHECKIN"];
            var checkOutDatetemp =row["DATECHECKOUT"];
            if (checkOutDatetemp.ToString() != "")
            {
                this.checkOutDate = (DateTime?)row["DATECHECKOUT"];
            }
            this.status = (int)row["ISPAID"];
        }

        public Bill(int id, DateTime Checkindate,DateTime checkoutdate,int status)
        {
            this.id = id;
            this.checkInDate = Checkindate;
            this.checkOutDate = checkoutdate;
            this.status = status;
        }

        public DateTime? CheckInDate { get => checkInDate; set => checkInDate = value; }
        public DateTime? CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public int Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }
    }
}
