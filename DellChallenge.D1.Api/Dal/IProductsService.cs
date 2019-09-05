using DellChallenge.D1.Api.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DellChallenge.D1.Api.Dal
{
    public interface IProductsService
    {
        IEnumerable<ProductDto> GetAll();
        Task<Product> GetProductByIdAsync(int id);
        ProductDto Add(NewProductDto newProduct);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, NewProductDto newProduct);
    }
}
