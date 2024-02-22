using MediatR;
using MediatrExercisev2.Abstraction.Responses.Item;
using MediatrExercisev2.Repository.Context;

namespace MediatrExercisev2.Application.Items.Commands.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, CreateItemDTO>
    {
        public readonly ApplicationDbContext _dbcontext;

        public CreateItemCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<CreateItemDTO> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = request.CreateItem();

            await _dbcontext.Items.AddAsync(item, cancellationToken);
            await _dbcontext.SaveChangesAsync();

            return new CreateItemDTO(item.Id);
        }
    }
}
