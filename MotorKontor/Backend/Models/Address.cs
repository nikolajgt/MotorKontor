using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Address
    {

        public Address() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetNumber { get; set; }
        public string Town { get; set; }
        public string Zipcode { get; set; }
    }
}
