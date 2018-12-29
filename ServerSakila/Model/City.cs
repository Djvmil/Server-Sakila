using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class City
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string City_Name { get; set; }
        [DataMember]

        public Country Country { get; set; }

        [DataMember]
        DateTime LastUpdate { get; set; }

        [DataMember]
        public ICollection<Address> Adresses { get; set; }
    }
}