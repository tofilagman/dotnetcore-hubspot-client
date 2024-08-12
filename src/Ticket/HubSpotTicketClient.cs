using Microsoft.Extensions.Logging;
using RapidCore.Network;
using Skarp.HubSpotClient.Core;
using Skarp.HubSpotClient.Core.Interfaces;
using Skarp.HubSpotClient.Core.Requests;
using Skarp.HubSpotClient.Ticket.Dto;
using Skarp.HubSpotClient.Ticket.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Skarp.HubSpotClient.Ticket
{
    public class HubSpotTicketClient : HubSpotBaseClient, IHubSpotTicketClient
    {
        public HubSpotTicketClient(
            IRapidHttpClient httpClient,
            ILogger<HubSpotTicketClient> logger,
            RequestSerializer serializer,
            string hubSpotBaseUrl,
            string apiKeyOrToken
        ) : base(httpClient, logger, serializer, hubSpotBaseUrl, apiKeyOrToken)
        {
        }

        public HubSpotTicketClient(string apiKeyOrToken)
       : base(
             new RealRapidHttpClient(new HttpClient()),
             NoopLoggerFactory.Get(),
             new RequestSerializer(new RequestDataConverter(NoopLoggerFactory.Get<RequestDataConverter>())),
             "https://api.hubapi.com",
             apiKeyOrToken)
        { }

        public async Task<T> CreateAsync<T>(ITicketHubSpotEntity entity) where T : IHubSpotEntity, new()
        {
            Logger.LogDebug("Ticket CreateAsync");
            var path = PathResolver(entity, HubSpotAction.Create);
            var data = await PostAsync<T>(path, entity);
            return data;
        }

        public async Task DeleteAsync(long dealId)
        {
            Logger.LogDebug("Ticket delete w. id: {0}", dealId);

            var path = PathResolver(new TicketHubSpotEntity(), HubSpotAction.Delete)
                .Replace(":ticketId:", dealId.ToString());

            await DeleteAsync<TicketHubSpotEntity>(path); 
        }

        public async Task<T> GetByIdAsync<T>(long dealId) where T : IHubSpotEntity, new()
        {
            Logger.LogDebug("Ticket Get by id ");
            var path = PathResolver(new TicketHubSpotEntity(), HubSpotAction.Get)
                .Replace(":ticketId:", dealId.ToString());
            var data = await GetAsync<T>(path);
            return data;
        }

        public Task<T> GetPropertiesAsync<T>() where T : IHubSpotEntity, new()
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync<T>(ITicketHubSpotEntity entity) where T : IHubSpotEntity, new()
        {
            Logger.LogDebug("Ticket update w. id: {0}", entity.Id);
            if (entity.Id < 1)
            {
                throw new ArgumentException("Ticket entity must have an id set!");
            }
            var path = PathResolver(entity, HubSpotAction.Update)
                .Replace(":ticketId:", entity.Id.ToString());

            var data = await PutAsync<T>(path, entity);
            return data;
        }

        public async Task<T> SearchAsync<T>(string name, object value) where T : IHubSpotEntity, new()
        {
            var model = new TicketSearchRequestOptions
            {
                FilterGroups = new List<RequestFilterGroup>
                    {
                       new RequestFilterGroup
                       {
                            Filters = new List<RequestFilter>
                            {
                                 new RequestFilter
                                 {
                                      PropertyName = name,
                                      Value = value
                                 }
                            }
                       }
                    }
            };

            var path = PathResolver(model, HubSpotAction.Search);
            var data = await ListAsPostAsync<T>(path, model);
            return data;
        }

        /// <summary>
        /// Resolve a hubspot API path based off the entity and operation that is about to happen
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string PathResolver(IRouteBasePath entity, HubSpotAction action)
        {
            switch (action)
            {
                case HubSpotAction.Create:
                    return $"{entity.RouteBasePath}/tickets";
                case HubSpotAction.Get:
                    return $"{entity.RouteBasePath}/tickets/:ticketId:";
                case HubSpotAction.List:
                    return $"{entity.RouteBasePath}/tickets";
                case HubSpotAction.Update:
                    return $"{entity.RouteBasePath}/tickets/:ticketId:";
                case HubSpotAction.Delete:
                    return $"{entity.RouteBasePath}/tickets/:ticketId:";
                case HubSpotAction.Search:
                    return $"{entity.RouteBasePath}/tickets/search";
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
        }
         
    }
}
