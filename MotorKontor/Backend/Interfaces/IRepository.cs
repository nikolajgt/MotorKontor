using MotorKontor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Interfaces
{
    public interface IRepository
    {
        //  POST METHODS
        Task<bool> PostCustomerAsync(Customer user);
        Task<bool> PostVehicleAsync(Vehicle vehicle);

        //  GET METHODS 
        Task<Customer> GetCustomerAsync(int id);
        Task<Vehicle> GetVehicleAsync(int vehicleid);
    }
}
