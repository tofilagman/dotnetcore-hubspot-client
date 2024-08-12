using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skarp.HubSpotClient.Ticket.Interfaces
{
    public interface IHubSpotTicketClient
    {
        /// <summary>
        /// Creates the deal entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        Task<T> CreateAsync<T>(ITicketHubSpotEntity entity) where T : IHubSpotEntity, new();
        /// <summary>
        /// Delete a deal from hubspot
        /// </summary>
        /// <param name="dealId"></param>
        /// <returns></returns>
        Task DeleteAsync(long dealId);
        /// <summary>
        /// Return a single deal by id from hubspot
        /// </summary>
        /// <param name="dealId"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetByIdAsync<T>(long dealId) where T : IHubSpotEntity, new(); 
        /// <summary>
        /// Update an existing deal in hubspot
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync<T>(ITicketHubSpotEntity entity) where T : IHubSpotEntity, new();
        /// <summary>
        /// List deal properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetPropertiesAsync<T>() where T : IHubSpotEntity, new();
    }
}
