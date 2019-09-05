using System.Collections.Generic;
using System.Threading.Tasks;
using DellChallenge.D2.Web.Models;
using RestSharp;

namespace DellChallenge.D2.Web.Services
{
    public class ProductService : IProductService
    {
        public ProductModel Add(NewProductModel newProduct)
        {
            var apiClient = new RestClient("http://localhost:2534/api");
            var apiRequest = new RestRequest("products", Method.POST, DataFormat.Json);
            apiRequest.AddJsonBody(newProduct);
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }

        public IEnumerable<ProductModel> GetAll()
        {
            
            var apiClient = new RestClient("http://localhost:2534/api");
            var apiRequest = new RestRequest("products", Method.GET, DataFormat.Json);
            var apiResponse = apiClient.Execute<List<ProductModel>>(apiRequest);
            return apiResponse.Data;
        }

        public async Task<bool> DeleteProductByIdAsync(int id)
        {
            var apiClient = new RestClient("http://localhost:2534/api");
            var apiRequest = new RestRequest($"/Products/{id}", Method.DELETE);
            var response =  apiClient.Execute<HttpResponse>(apiRequest);
            return response.IsSuccessful;
        }

        public bool UpdateProduct(NewProductModel newProduct,int id)
        {
            var apiClient = new RestClient("http://localhost:2534/api");
            var apiRequest = new RestRequest($"products/{id}", Method.PUT, DataFormat.Json);
            apiRequest.AddJsonBody(newProduct);
            var response = apiClient.Execute<HttpResponse>(apiRequest);
            return response.IsSuccessful;
        }

        public ProductModel GetById(int id)
        {
            var apiClient = new RestClient("http://localhost:2534/api");
            var apiRequest = new RestRequest($"products/{id}", Method.GET, DataFormat.Json);
            var response = apiClient.Execute<ProductModel>(apiRequest);
            return response.Data;
        }
    }
}
