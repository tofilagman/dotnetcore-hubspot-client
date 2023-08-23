using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Core.Requests
{
    [DataContract]
    public class RequestFilterGroup
    {
        [DataMember(Name = "filters")]
        public List<RequestFilter> Filters { get; set; }
    }

    [DataContract]
    public class RequestFilter
    {
        [DataMember(Name = "value")]
        public string Value { get; set; }
        [DataMember(Name = "highValue")]
        public string HighValue { get; set; }
        [DataMember(Name = "values")]
        public List<string> Values { get; set; }
        [DataMember(Name = "propertyName")]
        public string PropertyName { get; set; }
        [DataMember(Name = "operator")]
        public string Operator { get; set; } = "EQ";
    }
}
