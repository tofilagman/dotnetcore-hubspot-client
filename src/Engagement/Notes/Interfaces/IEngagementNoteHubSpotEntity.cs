using Skarp.HubSpotClient.Engagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Notes.Interfaces
{
    public interface IEngagementNoteHubSpotEntity : IEngagementHubSpotEntity
    {
        string Note { get; set; }
        string TimeStamp { get; set; }
        string OwnerId { get; set; }
    }
}
