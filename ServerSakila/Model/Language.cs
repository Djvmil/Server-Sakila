using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Language
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Name { get; set; }
        [DataMember]
        DateTime Last_update { get; set; }
       
        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}