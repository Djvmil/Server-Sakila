using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Amount { get; set; }

        [DataMember]

        public DateTime Payment_date { get; set; }
        [DataMember]
        DateTime last_updat { get; set; }

        [DataMember]
        public Customer Customers { get; set; }

        [DataMember]
        public Staff Staffs { get; set; }

        [DataMember]
        public Rental Rentals { get; set; }
    }
}