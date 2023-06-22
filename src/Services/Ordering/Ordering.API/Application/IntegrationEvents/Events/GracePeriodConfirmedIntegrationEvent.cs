using CleanArchitectureTemplate.BuildingBlocks.EventBus.Events;

namespace CleanArchitectureTemplate.Services.Ordering.API.Application.IntegrationEvents.Events;

public record GracePeriodConfirmedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }

    public GracePeriodConfirmedIntegrationEvent(int orderId) =>
        OrderId = orderId;
}