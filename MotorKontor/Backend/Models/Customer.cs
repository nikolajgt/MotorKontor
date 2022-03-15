using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Customer
    {
        public Customer() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public DateTime UserCreation { get; set; }
        //public virtual Address UserAddress { get; set; }
        public virtual List<Registration> UserVehicleRegistration { get; set; }

        public Customer(string username, string password, string firstname, string lastname, string email, string phonenr, DateTime created)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            PhoneNr = phonenr;
            UserCreation = created;
            UserVehicleRegistration = new List<Registration>();
        }
    }
}
