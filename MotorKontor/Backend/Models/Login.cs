using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class Login
    {
        public Login() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
