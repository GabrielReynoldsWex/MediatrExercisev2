using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;

namespace MediatrExercisev2.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<CreateCustomerDTO>
    { 
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public bool CustomerDiscount {  get; set; }

        public CreateCustomerCommand(string name, string contactNumber, bool customerDiscount) 
        {
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.CustomerDiscount = customerDiscount;
        }
    }
}