using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Dto
{
    [DataContract]
    public class EngagementAssociation
    {
        [DataMember(Name = "to")]
        public EngagementAssociationTo To { get; set; }

        [DataMember(Name = "types")]
        public List<EngagementAssociationType> Type { get; set; }
    }

    [DataContract]
    public class EngagementAssociationTo
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }
    }

    [DataContract]
    public class EngagementAssociationType
    {
        [DataMember(Name = "associationCategory")]
        public string AssociationCategory { get; set; }

        [DataMember(Name = "associationTypeId")]
        public int AssociationTypeId { get; set; }
    }
}
