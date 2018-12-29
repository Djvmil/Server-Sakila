using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        DateTime last_update { get; set; }

        [DataMember]
        public Film films { get; set; }

        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}