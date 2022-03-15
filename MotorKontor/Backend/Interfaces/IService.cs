using MotorKontor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Interfaces
{
    public interface IService
    {
        //  POST METHODS
        Task<bool> PostCustomerAsync(Customer user);
        Task<bool> PostVehicleAsync(Vehicle vehicle);

        //  GET METHODS 
        Task<Customer> GetCustomerAsync(int id);
        Task<List<Customer>> GetLatestCustomersListAsync();
        Task<Vehicle> GetVehicleAsync(int vehicleid);
        Task<List<Vehicle>> GetVehicleListAsync();
        Task<Registration> GetRegistrationAsync(int id);
        Task<List<Registration>> GetLatestRegistrationsListAsync();
    }
}
