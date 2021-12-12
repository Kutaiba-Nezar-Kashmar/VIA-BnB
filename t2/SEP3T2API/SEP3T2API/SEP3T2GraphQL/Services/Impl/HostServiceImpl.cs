﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEP3T2GraphQL.Models;
using SEP3T2GraphQL.Repositories;
using SEP3T2GraphQL.Services.Validation.HostValidation;
using SEP3T2GraphQL.Services.Validation.HostValidation.Impl;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SEP3T2GraphQL.Services.Impl
{
    public class HostServiceImpl : IHostService
    {
        private IHostRepository _hostRepository;
        private IHostValidation _hostValidation;

        public HostServiceImpl(IHostRepository hostRepository, IHostValidation hostValidation)
        {
            _hostRepository = hostRepository;
            _hostValidation = hostValidation;
        }


        public Task<Host> UpdateHost(Host host)
        {
            throw new NotImplementedException();
        }

        public async Task<Host> RegisterHostAsync(Host host)
        {
            Console.WriteLine("inside registerhost servie");
            if (await _hostValidation.IsValidHost(host))
            {
                try
                {
                    return await _hostRepository.RegisterHostAsync(host);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            throw new ArgumentException("Invalid host");
        }

        public async Task<Host> GetHostByEmail(string email)
        {
            try
            {
                return await _hostRepository.GetHostByEmailAsync(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Host> ValidateHostAsync(string email, string password)
        {
            var returnedHost = await GetHostByEmail(email);
            if (returnedHost == null) throw new KeyNotFoundException("user not found");
            if (returnedHost.Password != password)
            {
                throw new ArgumentException("the password is not matching");
            }
            else return returnedHost;
        }


        public async Task<Host> GetHostById(int id)
        {
            if (id is > 0 and < int.MaxValue && id != null)
            {
                try
                {
                    return await _hostRepository.GetHostByIdAsync(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            throw new Exception("Id must be bigger than 0");
        }

        public async Task<IEnumerable<Host>> GetAllNotApprovedHostsAsync()
        {
            var hostListToReturn = await _hostRepository.GetAllNotApprovedHostsAsync();
            if (hostListToReturn == null)
            {
                throw new ArgumentException("Host list is null");
            }

            return hostListToReturn;
        }

        public async Task<Host> UpdateHostStatusAsync(Host host)
        {
            Console.WriteLine(
                $"{this} {nameof(UpdateHostStatusAsync)} received params: {JsonSerializer.Serialize(host)}");
            if (host == null)
            {
                throw new ArgumentException("Host can't be null");
            }

            var updatedHost = await _hostRepository.UpdateHostStatusAsync(host);
            if (updatedHost == null)
            {
                throw new ArgumentException("Can't update the host status!!!");
            }

            return updatedHost;
        }
    }
}