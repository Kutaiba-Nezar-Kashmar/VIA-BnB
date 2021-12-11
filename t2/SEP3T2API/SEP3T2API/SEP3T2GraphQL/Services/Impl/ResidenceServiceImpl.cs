﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEP3T2GraphQL.Models;
using SEP3T2GraphQL.Repositories;
using SEP3T2GraphQL.Services.Impl;
using SEP3T2GraphQL.Services.Validation.ResidenceValidation;

namespace SEP3T2GraphQL.Services
{
    public class ResidenceServiceImpl : IResidenceService
    {
        private readonly IResidenceRepository _residenceRepository;
        private readonly IResidenceValidation _residenceValidation;
        private readonly ICityService _cityService;
        private readonly IAddressService _addressService;

        public ResidenceServiceImpl(IResidenceRepository residenceRepository, ICityService cityService,
            IAddressService addressService)
        {
            _residenceRepository = residenceRepository;
            _residenceValidation = new ResidenceValidationImpl();
            _cityService = cityService;
            _addressService = addressService;
        }

        public async Task<Residence> GetResidenceByIdAsync(int id)
        {
            if (id is > 0 and < int.MaxValue && id != null)
            {
                try
                {
                    return await _residenceRepository.GetResidenceByIdAsync(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            throw new Exception("ID must be bigger than 0");
        }

        public async Task<Residence> UpdateResidenceAvailabilityAsync(Residence residence)
        {
            if (_residenceValidation.IsValidAvailabilityPeriod(residence.AvailableFrom, residence.AvailableTo))
            {
                return await _residenceRepository.UpdateResidenceAvailabilityAsync(residence);
            }

            throw new ArgumentException("Publish attempt failed ");
        }

        public async Task<Residence> CreateResidenceAsync(Residence residence)
        {
            if (_residenceValidation.IsValidResidence(residence))
            {
                try
                {
                    var allCities = await _cityService.GetAllAsync();
                    var allAddresses = await _addressService.GetAllAsync();
                    // Creates new city if none exists. 
                    var existingCity = allCities.FirstOrDefault(c => c.Equals(residence.Address.City));
                    if (existingCity == null)
                    {
                        Console.WriteLine("Creating new city...");
                        residence.Address.City = await _cityService.CreateAsync(residence.Address.City);
                    }
                    else
                    {
                        Console.WriteLine("Existing city found...");
                        Console.WriteLine(existingCity.Id);
                        Console.WriteLine(existingCity.CityName);
                        residence.Address.City = existingCity;
                    }

                    var existingAddress = allAddresses.FirstOrDefault(a => a.Equals(residence.Address));
                    if (existingAddress == null)
                    {
                        Console.WriteLine("Creating new address...");
                        var newAddress= await _addressService.CreateAsync(residence.Address);
                        Console.WriteLine(newAddress.Id);
                        residence.Address.Id = newAddress.Id;
                    }
                    else
                    {
                        Console.WriteLine("Existing address found...");
                        residence.Address = existingAddress;
                    }

                    return await _residenceRepository.CreateResidenceAsync(residence);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            throw new ArgumentException("Invalid residence");
        }

        public async Task<IList<Residence>> GetAllRegisteredResidencesByHostIdAsync(int id)
        {
            if (id is > 0 and < int.MaxValue && id != null)
            {
                try
                {
                    return await _residenceRepository.GetAllRegisteredResidencesByHostIdAsync(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            throw new Exception("ID must be bigger than 0");
        }

        public async Task<IList<Residence>> GetAvailableResidencesAsync()
        {
            var allResidences = await _residenceRepository.GetAllAsync();
            return allResidences.Where(r => r.IsAvailable).ToList();
        }

        public async Task<Residence> UpdateResidenceAsync(Residence residence)
        {
            if (!_residenceValidation.IsValidResidenceForUpdate(residence)) throw new ArgumentException("Invalid residence");
            try
            {
                return await _residenceRepository.UpdateResidenceAsync(residence);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task<Residence> DeleteResidenceAsync(Residence residence)
        {
            if (residence.Id <= 0)
            {
                throw new ArgumentException("Invalid residence ID");
            }
            try
            {
                return await _residenceRepository.DeleteResidenceAsync(residence);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}