using MediatR;
using MediatrExercisev2.Abstraction.Responses.Purchase;

namespace MediatrExercisev2.Application.ItemPurchases.Commands.CreatePurchase
{
    public class CreatePurchaseCommand : IRequest<CreatePurchaseDTO>
    {
        public Guid CustomerID { get; set; }
        public Guid ItemID { get; set; }

        public CreatePurchaseCommand(Guid customerID, Guid itemID)
        {
            CustomerID = customerID;
            ItemID = itemID;
        }
    }
}
