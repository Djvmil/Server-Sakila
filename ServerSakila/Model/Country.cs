using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [MaxLength(55)]
        public string Contry_Name { get; set; }

        [DataMember]
        DateTime Last_UpdateC { get; set; }

        [DataMember]
        public ICollection<City> CityID { get; set; }
    }
}