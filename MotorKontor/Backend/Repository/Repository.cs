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

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _repository.Customer.SingleOrDefaultAsync(x => x.CustomerID == id);
        }

        public async Task<Vehicle> GetVehicleAsync(int vehicleid)
        {
            return await _repository.Vehicle.SingleOrDefaultAsync(x => x.VehicleID == vehicleid);
        }



        //  UPDATE METHODS 


        //  REMOVE METHODS 
    }
}
