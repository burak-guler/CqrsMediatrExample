using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.mediatR.Commands
{
    //public class AddProductCommand:IRequest
    //{
    //    public AddProductCommand(Product Product)
    //    {

    //    }
    //}
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
