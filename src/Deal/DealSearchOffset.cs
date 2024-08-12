using System.Runtime.Serialization;

namespace Skarp.HubSpotClient.Deal
{
    [DataContract]
    public class DealSearchOffset
    {
         
        [DataMember(Name = "hs_object_id")]
        public string HsObjectId { get; set; }
    }
}