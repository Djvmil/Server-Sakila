using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Film_Actor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]

        public Film Films { get; set; }

        [DataMember]
        public Actor Actor { get; set; }

        [DataMember]
        DateTime lastUpdate { get; set; }
    }
}