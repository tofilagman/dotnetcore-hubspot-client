using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Core.Associations
{
    public class HubSpotAssociationResult
    {
        public string Type { get; set; }
        public List<string> Id { get; set; }
    }
}
