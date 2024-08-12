using Skarp.HubSpotClient.Core.Associations;
using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Dto
{
    [DataContract]
    public class EngagementMetaData : IHubSpotEntity
    {
        [DataMember(Name = "body")]
        public string Body { get; set; } = "<p></p>";

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; } = "NOT_STARTED";

        [DataMember(Name = "taskType")]
        public string TaskType { get; set; }

        [DataMember(Name = "reminders")]
        public long[] Reminders { get; set; }

        [DataMember(Name = "sendDefaultReminder")]
        public bool SendDefaultReminder { get; set; } = true;

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
