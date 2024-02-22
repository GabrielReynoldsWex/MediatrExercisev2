using MediatR;
using MediatrExercisev2.Abstraction.Responses.Item;

namespace MediatrExercisev2.Application.Items.Queries.GetItems
{
    public class GetItemsQuery : IRequest<IList<GetItemDTO>>
    {
    }
}
