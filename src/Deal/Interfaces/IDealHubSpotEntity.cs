using Skarp.HubSpotClient.Core.Interfaces;

namespace Skarp.HubSpotClient.Deal.Interfaces
{
    public interface IDealHubSpotEntity : IHubSpotEntity, IRouteBasePath
    {
        long Id { get; set; }
        string Name { get; set; }
        string Stage { get; set; }
        string Pipeline { get; set; }
        long? OwnerId { get; set; }
        string CloseDate { get; set; }
        decimal Amount { get; set; }
        string DealType { get; set; } 
    }
}
