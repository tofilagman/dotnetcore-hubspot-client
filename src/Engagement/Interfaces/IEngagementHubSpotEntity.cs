using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Engagement.Interfaces
{
    public interface IEngagementHubSpotEntity : IHubSpotEntity
    {
        long? Id { get; set; }
        string RouteBasePath { get; }
    }
}
