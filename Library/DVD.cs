using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD : Media
    {
        public override int RentalLength { get; set; }

        public DVD()
        {
            RentedDate = DateTime.Today;
        }

        public override void PrintMediaDetails()
        {

        }

        public override DateTime ReturnDueDate()
        {
            return  ;
        }

        public override void SetRentedDate()
        {
            RentedDate = DateTime.Today;
        }

    }
}
