using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Registration
    {
        public Registration() { }
        [Key]
        public int RegistrationID { get; set; }
        public string CustomerID { get; set; }
        public string VehicleID { get; set; }
    }
}
