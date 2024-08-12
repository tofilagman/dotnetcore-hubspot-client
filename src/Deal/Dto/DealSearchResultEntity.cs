using System;
using System.Collections.Generic;
using System.Runtime.Serialization; 
using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Core.Interfaces;

namespace Skarp.HubSpotClient.Deal.Dto
{
    [DataContract]
    public class DealSearchResultEntity : IHubSpotEntity
    {
        [DataMember(Name = "results")]
        public IList<DealSearchHubSpotEntity> Results { get; set; }

        [DataMember(Name = "hasMore")]
        public bool MoreResultsAvailable { get; set; }

        [DataMember(Name = "offset")]
        public DealSearchOffset Offset { get; set; }

        public bool IsNameValue => false;

        public List<HubSpotAssociationResult> Associations { get; set; }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {

        }
    }
}