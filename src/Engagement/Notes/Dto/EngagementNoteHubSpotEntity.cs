using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Engagement.Dto;
using Skarp.HubSpotClient.Engagement.Notes.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Notes.Dto
{
    [DataContract]
    public class EngagementNoteHubSpotEntity : IEngagementNoteHubSpotEntity
    {
        /// <summary>
        /// Contacts unique Id in HubSpot
        /// </summary>
        [DataMember(Name = "vid")]
        [IgnoreDataMember]
        public long? Id { get; set; }

        [DataMember(Name = "hs_note_body")]
        [IgnoreDataMember]
        public string Note { get; set; }

        [DataMember(Name = "hs_timestamp")]
        [IgnoreDataMember]
        public string TimeStamp { get; set; }

        [DataMember(Name = "hubspot_owner_id")]
        [IgnoreDataMember]
        public string OwnerId { get; set; }

        [IgnoreDataMember]
        public int AssociationId { get; set; }

        [IgnoreDataMember]
        public long AssociateTo { get; set; }

        public string RouteBasePath => "/crm/v3";

        public bool IsNameValue => false;

        public List<HubSpotAssociationResult> Associations { get; set; }

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {

        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
            var prop = new Dictionary<string, object>
            {
                { "hs_timestamp" , TimeStamp },
                { "hs_note_body", Note },
                //{"hubspot_owner_id", OwnerId }
            };

            dataEntity.Properties = prop;

            //add associations
            dataEntity.Associations = new List<EngagementAssociation> {
                new EngagementAssociation {
                     To = new EngagementAssociationTo
                     {
                          Id = AssociateTo
                     },
                      Type = new List<EngagementAssociationType>
                      {
                           new EngagementAssociationType
                           {
                                AssociationCategory = "HUBSPOT_DEFINED",
                                AssociationTypeId = AssociationId
                           }
                      }
                }
            };

        }
    }
}
