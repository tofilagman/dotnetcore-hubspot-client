using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Ticket.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Ticket.Dto
{
    [DataContract]
    public class TicketHubSpotEntity : ITicketHubSpotEntity
    {
        [DataMember(Name = "hs_ticket_id")]
        [IgnoreDataMember]
        public long Id { get; set; }
        [DataMember(Name = "subject")]
        public string Name { get ; set ; }
        [DataMember(Name = "hs_created_by_user_id")]
        public long? OwnerId { get; set; }
         

        public List<HubSpotAssociationResult> Associations { get; set; }

        public string RouteBasePath => "/crm/v3/objects";
        public bool IsNameValue => true;

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
            throw new NotImplementedException();
        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
            throw new NotImplementedException();
        }
    }
}
