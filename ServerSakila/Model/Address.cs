using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string Adresse_name { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string District { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string Postal_Code { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string Phone { get; set; }

        [DataMember]
        public City City { get; set; }

        [DataMember]
        public ICollection<Store> stores { get; set; }

        [DataMember]
        public ICollection<Customer> customers { get; set; }

        [DataMember]
        public ICollection<Staff> staffs { get; set; }

    }
}