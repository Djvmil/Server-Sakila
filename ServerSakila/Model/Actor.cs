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
        public int Actor_ID { get; set; }

        [DataMember]
        public String First_Name { get; set; }

        [DataMember]
        public String Last_Name { get; set; }
       
        [DataMember]
        public DateTime Last_Update { get; set; }
    }
}
