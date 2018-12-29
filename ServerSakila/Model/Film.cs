using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSakila.Model
{
    [DataContract]
    public class Film
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [MaxLength(255)]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        [MaxLength(4)]
        public string Release_Year { get; set; }
        [DataMember]
        public int Rental_duration { get; set; }
        [DataMember]
        public int Rental_Rate { get; set; }
        [DataMember]
        public int Length { get; set; }
        [DataMember]
        public int Remplacement_Cost { get; set; }
        [DataMember]
        [MaxLength(10)]
        public string rating { get; set; }
        [DataMember]
        [MaxLength(100)]
        public string Special_Future { get; set; }
        [DataMember]
        DateTime last_updat { get; set; }

        [DataMember]
        public Language Language1 { get; set; }

        [DataMember]
        public Language Language2 { get; set; }


        [DataMember]
        public ICollection<Inventory> inventories { get; set; }

        [DataMember]
        public ICollection<Film_Actor> film_actors { get; set; }

        [DataMember]
        public ICollection<Film_Category> film_Categories { get; set; }

    }
}