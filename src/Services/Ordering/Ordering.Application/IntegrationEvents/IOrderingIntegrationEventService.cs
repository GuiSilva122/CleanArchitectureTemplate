using CleanArchitectureTemplate.BuildingBlocks.EventBus.Events;

namespace CleanArchitectureTemplate.Services.Ordering.Application.IntegrationEvents;

public interface IOrderingIntegrationEventService
{
    Task PublishEventsThroughEventBusAsync(Guid transactionId);
    Task AddAndSaveEventAsync(IntegrationEvent evt);
}
