using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Store
    {

        [DataMember]
        public int Id { get; set; }
      

        [DataMember]
        public Staff Staff { get; set; }

        [DataMember]
        DateTime lastupdate { get; set; }

        [DataMember]
        public Address adresse { get; set; }

        [DataMember]
        public ICollection<Customer> customers { get; set; }

        [DataMember]
        public ICollection<Staff> staffs { get; set; }

        [DataMember]
        public ICollection<Inventory> inventories { get; set; }
    }
}