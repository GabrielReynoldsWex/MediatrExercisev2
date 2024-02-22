using MediatrExercisev2.Abstraction.Responses.Item;
using MediatrExercisev2.Domain.Entities.ItemClass;

namespace MediatrExercisev2.Application.Items.Queries.GetItems
{
    public static class GetItemsQueryExtension
    {
        public static GetItemDTO MapTo(this Item item)
        {
            return new GetItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Category = item.Category,
                Price = item.Price.ToString()
            };
        }
    }
}
