using System;
using System.Threading.Tasks;
using CatQL.GraphQL.Client;
using CatQL.GraphQL.QueryResponses;
using Newtonsoft.Json;
using SEP3BlazorT1Client.Data.Impl.ResponseTypes;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl
{
    public partial class GraphQlGuestService : IGuestService
    {
        private const string Url = "https://localhost:5001/graphql";
        private readonly GqlClient _client = new GqlClient(Url);

        public async Task<Guest> CreateGuestAsync(Guest guest)
        {
            GqlQuery createGuestMutation = new GqlQuery()
            {
                Query = @"mutation($newGuest:GuestInput){
                          createGuest(guest:$newGuest){
                            viaId,
                            guestReviews{
                              id,
                              rating,
                              text,
                              hostId
                            },
                            isApprovedGuest,
                            id,
                            firstName,
                            lastName,
                            phoneNumber,
                            email,
                            password,
                            hostReviews{
                              id,
                              viaId,
                              rating,
                              text
                            },
                            profileImageUrl,
                            cpr,
                            isApprovedHost
                          }
                        }",
                Variables = new {newGuest = guest}
            };

            var response = await _client.PostQueryAsync<CreateGuestMutationResponseType>(createGuestMutation);
            if (response.Errors != null)
            {
                throw new ArgumentException(JsonConvert.SerializeObject(response.Errors).Split(",")[4].Split(":")[2]); 
            }

            return response.Data.CreateGuest; 
        }
    }
}