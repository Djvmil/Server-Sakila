using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Staff
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string First_Name { get; set; }
        [DataMember]
        public string Last_first { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string active { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public byte[] Picture { get; set; }
        [DataMember]
        DateTime Last_update { get; set; }

        [DataMember]
        public Address adresse { get; set; }

        [DataMember]
        public Store stor { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }

        [DataMember]
        public ICollection<Payment> payements { get; set; }
    }
}