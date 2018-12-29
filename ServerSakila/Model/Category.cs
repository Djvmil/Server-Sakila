using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Category
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Name { get; set; }
        [DataMember]
        DateTime last_update { get; set; }

        [DataMember]
        public ICollection<Film_Category> film_Categories { get; set; }
    }
}