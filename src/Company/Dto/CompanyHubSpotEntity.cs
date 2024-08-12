﻿using Skarp.HubSpotClient.Company.Interfaces;
using Skarp.HubSpotClient.Core.Associations;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Skarp.HubSpotClient.Company.Dto
{
    [DataContract]
    public class CompanyHubSpotEntity : ICompanyHubSpotEntity
    {
        [IgnoreDataMember]
        [DataMember(Name = "companyId")]
        public long Id { get; set; }

        [DataMember(Name = "hubspot_owner_id")]
        public long? OwnerId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "domain")]
        public string? Domain { get; set; }

        [DataMember(Name = "website")]
        public string? Website { get; set; }

        [DataMember(Name = "description")]
        public string? Description { get; set; }

        public virtual string RouteBasePath => "/companies/v2";
        public bool IsNameValue => true;

        public List<HubSpotAssociationResult> Associations { get; set; }

        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {

        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {

        }
    }
}
