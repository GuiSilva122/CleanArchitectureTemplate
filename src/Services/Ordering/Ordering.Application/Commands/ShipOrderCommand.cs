namespace CleanArchitectureTemplate.Services.Ordering.Application.Commands;

public class ShipOrderCommand : IRequest<bool>
{

    [DataMember]
    public int OrderNumber { get; private set; }

    public ShipOrderCommand(int orderNumber)
    {
        OrderNumber = orderNumber;
    }
}
