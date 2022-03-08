using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Vehicle
    {
        public Vehicle() { }

        [Key]
        public int VehicleID { get; set; }
        public string VehicleModel { get; set; }
        public virtual Fuel Fuel { get; set; }

        public int VehicleRegistrationID { get; set; }
        [ForeignKey("VehicleRegistrationID")]
        public virtual Registration VehicleRegistration { get; set; }

        public Vehicle(string model, Fuel fuel)
        {
            VehicleModel = model;
            Fuel = fuel;
        }
    }

    public enum Fuel
    {
        E10,
        E15,
        E85
    }
}
