using System.Runtime.CompilerServices;

using MediatrExercisev2.Domain.Entities.PurchaseClass;

namespace MediatrExercisev2.Application.ItemPurchases.Commands.CreatePurchase
{
    public static class CreatePurchaseCommandExtension
    {
        public static Purchase CreatePurchase(this CreatePurchaseCommand command)
        {
            var purchase = new Purchase();

            purchase.CustomerId = command.CustomerID;
            purchase.ItemId = command.ItemID;

            return purchase;
        }
    }
}
