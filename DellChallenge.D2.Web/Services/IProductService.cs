using DellChallenge.D2.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DellChallenge.D2.Web.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel Add(NewProductModel newProduct);
        Task<bool> DeleteProductByIdAsync(int id);
        bool UpdateProduct(NewProductModel newProduct, int id);
        ProductModel GetById(int id);
    }
}