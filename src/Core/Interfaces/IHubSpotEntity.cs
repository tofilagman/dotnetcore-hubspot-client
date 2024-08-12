using Skarp.HubSpotClient.Core.Associations;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

namespace Skarp.HubSpotClient.Core.Interfaces
{
    public interface IHubSpotEntity
    {
        bool IsNameValue { get; }

        /// <summary>
        /// Decorate your class with HubSpotAssociation attribute
        /// </summary>
        [IgnoreDataMember]
        public List<HubSpotAssociationResult> Associations { get; set; }

        void ToHubSpotDataEntity(ref dynamic dataEntity);

        void FromHubSpotDataEntity(dynamic hubspotData);
    }
}
