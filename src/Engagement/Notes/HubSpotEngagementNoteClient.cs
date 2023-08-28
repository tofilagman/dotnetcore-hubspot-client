using Microsoft.Extensions.Logging;
using RapidCore.Network;
using Skarp.HubSpotClient.Core;
using Skarp.HubSpotClient.Core.Interfaces;
using Skarp.HubSpotClient.Core.Requests;
using Skarp.HubSpotClient.Engagement.Interfaces;
using Skarp.HubSpotClient.Engagement.Notes.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Skarp.HubSpotClient.Engagement.Notes
{
    public class HubSpotEngagementNoteClient : HubSpotBaseClient
    {
        public HubSpotEngagementNoteClient(
          IRapidHttpClient httpClient,
          ILogger<HubSpotEngagementClient> logger,
          RequestSerializer serializer,
          string hubSpotBaseUrl,
          string apiKey)
          : base(httpClient, logger, serializer, hubSpotBaseUrl, apiKey)
        {
        }

        public HubSpotEngagementNoteClient(string apiKey)
        : base(
              new RealRapidHttpClient(new HttpClient()),
              NoopLoggerFactory.Get(),
              new RequestSerializer(new RequestDataConverter(NoopLoggerFactory.Get<RequestDataConverter>())),
              "https://api.hubapi.com",
              apiKey)
        { }

        /// <summary>
        /// Creates the Engagement notes asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> CreateAsync<T>(IEngagementNoteHubSpotEntity entity) where T : IHubSpotEntity, new()
        {
            Logger.LogDebug("Engagement Note CreateAsync");
            var path = PathResolver(entity, HubSpotAction.Create);
            var data = await PostAsync<T>(path, entity);
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
                    return $"{entity.RouteBasePath}/objects/notes"; 
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
        }
    }
}
