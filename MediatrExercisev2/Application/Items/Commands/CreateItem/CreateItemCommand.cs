using MediatR;
using MediatrExercisev2.Abstraction.Responses.Item;

namespace MediatrExercisev2.Application.Items.Commands.CreateItem
{
    public class CreateItemCommand : IRequest<CreateItemDTO>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public CreateItemCommand(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
