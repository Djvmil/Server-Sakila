using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ServeurSakila.Model
{
    [DataContract]
    public class Actor
    {
        [DataMember]
        public int ActorId { get; set; }

        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String LastName { get; set; }
       
        [DataMember]
        public DateTime LastUpdate { get; set; }
    }
}
