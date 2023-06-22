namespace CleanArchitectureTemplate.Services.Ordering.Application.Commands;

public class SetPaidOrderStatusCommand : IRequest<bool>
{

    [DataMember]
    public int OrderNumber { get; private set; }

    public SetPaidOrderStatusCommand(int orderNumber)
    {
        OrderNumber = orderNumber;
    }
}
