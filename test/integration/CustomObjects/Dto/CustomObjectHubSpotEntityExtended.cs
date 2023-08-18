using Skarp.HubSpotClient.CustomObjects.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integration.CustomObjects.Dto
{
    public class CustomObjectHubSpotEntityExtended : CustomObjectHubSpotEntity
    {
        public CustomObjectHubSpotEntityExtended()
        {
            ObjectTypeId = "2-6013641";
        }

        public string my_object_property { get; set; }
    }
}
