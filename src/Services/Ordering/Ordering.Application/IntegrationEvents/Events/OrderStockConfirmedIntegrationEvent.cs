using CleanArchitectureTemplate.BuildingBlocks.EventBus.Events;

namespace CleanArchitectureTemplate.Services.Ordering.Application.IntegrationEvents.Events;

public record OrderStockConfirmedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }

    public OrderStockConfirmedIntegrationEvent(int orderId) => OrderId = orderId;
}
