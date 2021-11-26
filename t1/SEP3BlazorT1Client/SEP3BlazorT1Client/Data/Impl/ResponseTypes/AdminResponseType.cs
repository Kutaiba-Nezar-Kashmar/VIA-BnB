using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes
{
    public class AdminResponseType
    {
        [JsonProperty("adminByEmail")] public Administrator Administrator { get; set; }
    }
}