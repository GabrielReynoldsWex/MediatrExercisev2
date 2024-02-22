using MediatrExercisev2.Domain.Entities.ItemClass;

namespace MediatrExercisev2.Application.Items.Commands.CreateItem
{
    public static class CreateItemCommandExtension
    {
        public static Item CreateItem(this CreateItemCommand command)
        {
            var Item = new Item(command.Name, command.Category, command.Price);
            return Item;
        }
    }
}
