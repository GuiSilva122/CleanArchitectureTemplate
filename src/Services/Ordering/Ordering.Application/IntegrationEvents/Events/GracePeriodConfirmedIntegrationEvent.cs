﻿using CleanArchitectureTemplate.BuildingBlocks.EventBus.Events;

namespace CleanArchitectureTemplate.Services.Ordering.Application.IntegrationEvents.Events;

public record GracePeriodConfirmedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }

    public GracePeriodConfirmedIntegrationEvent(int orderId) =>
        OrderId = orderId;
}