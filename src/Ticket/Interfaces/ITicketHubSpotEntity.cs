using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Ticket.Interfaces
{
    public interface ITicketHubSpotEntity : IHubSpotEntity, IRouteBasePath
    {
        long Id { get; set; }
        string Name { get; set; } 
        long? OwnerId { get; set; }
    }
}
