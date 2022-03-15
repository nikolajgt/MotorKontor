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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VehicleID { get; set; }
        public string VehicleModel { get; set; }
        public virtual Fuel Fuel { get; set; }
        public DateTime LeasedDate { get; set; }

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
