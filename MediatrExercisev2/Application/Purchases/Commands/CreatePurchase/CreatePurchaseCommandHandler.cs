using MediatR;
using MediatrExercisev2.Abstraction.Responses.Purchase;
using MediatrExercisev2.Application.ItemPurchases.Commands.CreatePurchase;
using MediatrExercisev2.Repository.Context;

namespace MediatrExercisev2.Application.Purchases.Commands.CreatePurchase
{
    public class CreatePurchaseCommandHandler : IRequestHandler<CreatePurchaseCommand, CreatePurchaseDTO> 
    {
        private readonly ApplicationDbContext _dbcontext;

        public CreatePurchaseCommandHandler(ApplicationDbContext dbcontext) 
        {
            _dbcontext = dbcontext;
        }

        public async Task<CreatePurchaseDTO> Handle(CreatePurchaseCommand request, CancellationToken cancellationToken)
        { 
            var purchase = request.CreatePurchase(); 

            await _dbcontext.Purchases.AddAsync(purchase, cancellationToken);
            await _dbcontext.SaveChangesAsync();

            return new CreatePurchaseDTO(purchase.Id);
        }
    }
}
