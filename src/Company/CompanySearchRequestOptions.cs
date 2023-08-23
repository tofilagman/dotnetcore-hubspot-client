using Skarp.HubSpotClient.Core.Interfaces;
using Skarp.HubSpotClient.Core.Requests;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Skarp.HubSpotClient.Company
{
    [DataContract]
    public class CompanySearchRequestOptions : IRouteBasePath
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; } = 100;
        [DataMember(Name = "properties")]
        public List<string> Properties { get; set; } = new List<string> { "domain", "name", "website" };
        [DataMember(Name = "filterGroups")]
        public List<RequestFilterGroup> FilterGroups { get; set; }

        public string RouteBasePath => "/crm/v3/objects";
    }
}