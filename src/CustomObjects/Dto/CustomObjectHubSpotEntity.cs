using Skarp.HubSpotClient.CustomObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.CustomObjects.Dto
{
    public class CustomObjectHubSpotEntity : ICustomObjectHubSpotEntity
    {
        public long? Id { get; set; }
        public string ObjectTypeId { get; set; }
        public string RouteBasePath => "/crm/v3/objects";
        public bool IsNameValue => false;
        public void ToHubSpotDataEntity(ref dynamic dataEntity) { }
        public void FromHubSpotDataEntity(dynamic hubspotData) { }
    }
}
