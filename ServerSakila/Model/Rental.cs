using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Rental
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Rental_Date { get; set; }
        [DataMember]
        public DateTime Return_Date { get; set; }
        [DataMember]
        DateTime Last_update { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public Staff staffs { get; set; }

        [DataMember]
        public Inventory Inventories { get; set; }

        public ICollection<Payment> payements { get; set; }

    }
}