using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Skarp.HubSpotClient.Deal.Dto
{
    [DataContract]
    public class DealSearchHubSpotEntity : IHubSpotEntity
    {
        [DataMember(Name = "hs_object_id")]
        public long Id { get; set; }

        [DataMember(Name = "createdAt")]
        public DateTime? CreatedAt { get; set; }
        [DataMember(Name = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [DataMember(Name = "archived")]
        public bool Archived { get; set; }

        [DataMember(Name = "createdate")]
        public DateTime? CreateDate { get; set; }
        [DataMember(Name = "domain")]
        public string? Domain { get; set; }
        [DataMember(Name = "hs_lastmodifieddate")]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "website")]
        public string Website { get; set; }

        public bool IsNameValue => true;

        public List<HubSpotAssociationResult> Associations { get; set; }

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
             
        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
            
        }
    }

  
}
