using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Registration
    {
        public Registration() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegistrationID { get; set; }
        public string CustomerFullName { get; set; }
        public DateTime LeasedCreated { get; set; }
        public DateTime LeasedEnding { get; set; }

        public int VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public virtual Vehicle VehicleRegistrated { get; set; }


        public Registration(string fullname, int days)
        {
            CustomerFullName = fullname;
            LeasedCreated = DateTime.Now;
            LeasedEnding = LeasedCreated.AddDays(days);
        }


    }
}
