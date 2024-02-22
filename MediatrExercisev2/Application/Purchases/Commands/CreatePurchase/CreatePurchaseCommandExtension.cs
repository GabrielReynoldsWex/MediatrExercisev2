using System.Runtime.CompilerServices;

using MediatrExercisev2.Domain.Entities.PurchaseClass;

namespace MediatrExercisev2.Application.ItemPurchases.Commands.CreatePurchase
{
    public static class CreatePurchaseCommandExtension
    {
        public static Purchase CreateItemPurchase(this CreatePurchaseCommand command)
        {
            var ItemPurcase = new Purchase(command.CustomerID, command.ItemID);
            return ItemPurcase;
        }
    }
}
