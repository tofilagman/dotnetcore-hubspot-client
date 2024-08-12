using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Dto
{
    [DataContract]
    public class EngagementAttachment : IHubSpotEntity
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        public string RouteBasePath => "";
        public bool IsNameValue => false;
        public List<HubSpotAssociationResult> Associations { get; set; }
        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {

        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {

        }
    }
}
