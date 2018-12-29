using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string First_Name { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Last_first { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Email { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Active { get; set; }
        [DataMember]
        public DateTime create_date { get; set; }
        [DataMember]
        [Timestamp]
        public byte[] Last_update { get; set; }

        [DataMember]
        public  Address addresse{ get; set; }

        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
        [DataMember]
        public ICollection<Payment> payements { get; set; }
    }
}