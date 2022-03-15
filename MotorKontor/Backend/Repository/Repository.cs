using Microsoft.EntityFrameworkCore;
using MotorKontor.Backend.Interfaces;
using MotorKontor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Repository
{
    public class Repository : IRepository
    {
        private readonly MyContext _repository;

        public Repository(MyContext repository)
        {
            _repository = repository;
        }



        //  POST METHODS 

        public async Task<bool> PostCustomerAsync(Customer user)
        {
            await _repository.Customer.AddAsync(user);
            return (await _repository.SaveChangesAsync()) > 0;
        }

        public async Task<bool> PostVehicleAsync(Vehicle vehicle)
        {
            await _repository.Vehicle.AddAsync(vehicle);
            return (await _repository.SaveChangesAsync()) > 0; ;
        }



        //  GET METHODS 

        //GET CUSTOMER FROM ID
        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _repository.Customer.SingleOrDefaultAsync(x => x.CustomerID == id);
        }

        //GET 5 LATEST USERs CREATED
        public async Task<List<Customer>> GetLatestCustomersListAsync()
        {
            return await _repository.Customer.OrderByDescending(p => p.UserCreation).Take(5).ToListAsync();
        }


        //GET VEHICLE FROM ID
        public async Task<Vehicle> GetVehicleAsync(int id)
        {
            return await _repository.Vehicle.SingleOrDefaultAsync(x => x.VehicleID == id);
        }

        public async Task<List<Vehicle>> GetVehicleListAsync()
        {
            return await _repository.Vehicle.OrderByDescending(p => p.LeasedDate).Take(5).ToListAsync();
        }

        public async Task<Registration> GetRegistrationAsync(int id)
        {
            return await _repository.Registration.SingleOrDefaultAsync(x => x.RegistrationID == id);
        }

        public async Task<List<Registration>> GetLatestRegistrationsListAsync()
        {
            return await _repository.Registration.OrderByDescending(p => p.LeasedCreated).Take(5).ToListAsync();
        }


        //  UPDATE METHODS 


        //  REMOVE METHODS 
    }
}
