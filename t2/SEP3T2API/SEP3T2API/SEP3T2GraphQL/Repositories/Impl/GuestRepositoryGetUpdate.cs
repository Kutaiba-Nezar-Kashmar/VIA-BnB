﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEP3T2GraphQL.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SEP3T2GraphQL.Repositories.Impl
{
    public partial class GuestRepository : IGuestRepository
    {
        public async Task<Guest> GetGuestById(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"{Uri}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync()); 
            }

            var fetchedGuest = JsonSerializer.Deserialize<Guest>(await response.Content.ReadAsStringAsync());
            return fetchedGuest;
        }

        public async Task<Guest> GetGuestByStudentNumber(int studentNumber)
        {
            
            HttpResponseMessage response = await _client.GetAsync($"{Uri}?studentNumber={studentNumber}");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync()); 
            }

            var fetchedGuests = JsonConvert.DeserializeObject<List<Guest>>(await response.Content.ReadAsStringAsync());
            var fetchedGuest = fetchedGuests[0];
            return fetchedGuest;
        }

        public async Task<Guest> GetGuestByEmail(string email)
        {
            var response = await _client.GetAsync($"{Uri}?={email}");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var result = await response.Content.ReadAsStringAsync();
            var guestToReturn = JsonSerializer.Deserialize<Guest[]>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return guestToReturn[0];
        }


        public async Task<Guest> UpdateGuest(Guest guest)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Guest>> GetAllGuests()
        {
            HttpResponseMessage response = await _client.GetAsync($"{Uri}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync()); 
            }
            var fetchedGuests = JsonSerializer.Deserialize<List<Guest>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions(){PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
            return fetchedGuests;
        }

        public async Task<IEnumerable<Guest>> GetAllNotApprovedGuests()
        {
            HttpResponseMessage response = await _client.GetAsync(Uri + $"/notApproved");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            var result = await response.Content.ReadAsStringAsync();
            var guestListToReturn = JsonSerializer.Deserialize<List<Guest>>(result,  new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return guestListToReturn;
        }

        public async Task<Guest> UpdateGuestStatus(Guest guest)
        {
            var guestAsJson = JsonSerializer.Serialize(guest, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            HttpContent content = new StringContent(guestAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PatchAsync($"{Uri}/{guest.Id}/approval", content);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{this} caught exception: {await response.Content.ReadAsStringAsync()} with status code {response.StatusCode}");
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var updatedGuest = JsonSerializer.Deserialize<Guest>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return updatedGuest;
        }
    }
}