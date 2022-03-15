using MotorKontor.Backend.Interfaces;
using MotorKontor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }
        // Her er hvor man indsætter logikken. Det vil sige at hvis man for eksempel skal ændre et navn på en Customer
        // skal det gøres her via at hente user ned. Repositoryen fungere KUN til at sende dataen afsted via metoder du kan access herfra.
        // _repository sørger for at man kan access de metoder.



        //  POST METHODS 
        public async Task<bool> PostCustomerAsync(Customer customer)
        {
            return await _repository.PostCustomerAsync(customer);
        }

        public async Task<bool> PostVehicleAsync(Vehicle vehicle)
        {
            return await _repository.PostVehicleAsync(vehicle);
        }
        

        //  GET METHODS 
        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _repository.GetCustomerAsync(id);
        }

        public async Task<List<Customer>> GetLatestCustomersListAsync()
        {
            return await _repository.GetLatestCustomersListAsync();
        }

        public async Task<Vehicle> GetVehicleAsync(int vehicleid)
        {
            return await _repository.GetVehicleAsync(vehicleid);
        }
        
        public async Task<List<Vehicle>> GetVehicleListAsync()
        {
            return await _repository.GetVehicleListAsync();
        }

        public async Task<Registration> GetRegistrationAsync(int id)
        {
            return await _repository.GetRegistrationAsync(id);
        }

        public async Task<List<Registration>> GetLatestRegistrationsListAsync()
        {
            return await _repository.GetLatestRegistrationsListAsync();
        }

        //  UPDATE METHODS 


        //  REMOVE METHODS 
    }
}
