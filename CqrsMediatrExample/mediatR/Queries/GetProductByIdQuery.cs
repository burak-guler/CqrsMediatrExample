using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.mediatR.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
