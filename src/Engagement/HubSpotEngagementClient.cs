using Skarp.HubSpotClient.Core.Interfaces;
using Skarp.HubSpotClient.Core.Requests;
using Skarp.HubSpotClient.Core;
using System;
using System.Threading.Tasks;
using Skarp.HubSpotClient.Engagement.Interfaces;
using RapidCore.Network;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Skarp.HubSpotClient.Company;
using Skarp.HubSpotClient.Engagement.Dto;
using Flurl;

namespace Skarp.HubSpotClient.Engagement
{
    public class HubSpotEngagementClient : HubSpotBaseClient
    { 
        public HubSpotEngagementClient(
            IRapidHttpClient httpClient,
            ILogger<HubSpotEngagementClient> logger,
            RequestSerializer serializer,
            string hubSpotBaseUrl,
            string apiKey)
            : base(httpClient, logger, serializer, hubSpotBaseUrl, apiKey)
        {
        }
         
        public HubSpotEngagementClient(string apiKey)
        : base(
              new RealRapidHttpClient(new HttpClient()),
              NoopLoggerFactory.Get(),
              new RequestSerializer(new RequestDataConverter(NoopLoggerFactory.Get<RequestDataConverter>())),
              "https://api.hubapi.com",
              apiKey)
        { }
         
        public async Task<T> GetRecent<T>(EngagementRecentRequestOptions opts = null) where T : IHubSpotEntity, new()
        {
            Logger.LogDebug("Engagement GetRecent");
            opts ??= new EngagementRecentRequestOptions();

            var path = PathResolver(new EngagementHubSpotEntity(), HubSpotAction.Recent)
                            .SetQueryParam("count", opts.NumberOfCount);
            if (opts.Since.HasValue)
            {
                path = path.SetQueryParam("since", opts.Since);
            }
            var data = await ListAsync<T>(path);
            return data;
        }
         
        /// <summary>
        /// Resolve a hubspot API path based off the entity and opreation that is about to happen
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string PathResolver(IEngagementHubSpotEntity entity, HubSpotAction action)
        {
            switch (action)
            {
                case HubSpotAction.Create:
                    return $"{entity.RouteBasePath}/engagements";
                case HubSpotAction.Recent:
                    return $"{entity.RouteBasePath}/engagements/recent/modified"; 
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
        }
    }
}
