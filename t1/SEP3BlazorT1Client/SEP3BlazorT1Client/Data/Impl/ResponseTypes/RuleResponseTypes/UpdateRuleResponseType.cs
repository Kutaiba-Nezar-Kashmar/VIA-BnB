using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes.RuleResponseTypes
{
    public class UpdateRuleResponseType
    {
        [JsonProperty("updateResidenceRule")] public Rule Rule { get; set; }
    }
}