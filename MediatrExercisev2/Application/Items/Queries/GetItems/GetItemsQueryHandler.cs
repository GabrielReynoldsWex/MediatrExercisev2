using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;
using MediatrExercisev2.Abstraction.Responses.Item;
using MediatrExercisev2.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatrExercisev2.Application.Items.Queries.GetItems
{
    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, IList<GetItemDTO>>
    {
        private readonly ApplicationDbContext _dbcontext;

        public GetItemsQueryHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IList<GetItemDTO>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            var items = await _dbcontext.Items.ToListAsync();
            var List = new List<GetItemDTO>();
            foreach (var product in items)
            {
                var item = product.MapTo();
                List.Add(item);
            }
            return List;
        }
    }
}
