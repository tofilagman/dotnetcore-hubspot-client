using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.CustomObjects.Interfaces
{
    public interface ICustomObjectHubSpotEntity : IHubSpotEntity
    {
        long? Id { get; set; }
        /// <summary>
        /// The Id Hubspot gives to your custom object when you create it for the first time
        /// </summary>
        string ObjectTypeId { get; set; }
        string RouteBasePath { get; }
    }
}
