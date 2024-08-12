using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skarp.HubSpotClient.Core.Associations
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class HubSpotAssociation : Attribute
    { 

        public List<string> Names { get; private set; }

        public HubSpotAssociation(params string[] names)
        {
            Names = names.ToList();
        }
    }
}
