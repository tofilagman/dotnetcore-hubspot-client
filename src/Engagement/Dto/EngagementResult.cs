using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Dto
{
    [DataContract]
    public class EngagementResult : IHubSpotEntity
    {
        [DataMember(Name = "results")]
        public List<EngagementHubSpotEntity> Results { get; set; }

        public bool IsNameValue => false;

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
           
        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
           
        }
    }
}
