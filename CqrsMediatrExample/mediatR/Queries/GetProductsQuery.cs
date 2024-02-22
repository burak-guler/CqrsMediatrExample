using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.mediatR.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
