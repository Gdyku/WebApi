using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApi.DTOModels;

namespace WebApi.Interfaces
{
    public interface IProductLogic
    {
        Task<List<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProduct(Guid ID);
        Task CreateProduct(ProductDTO product);
        Task EditProduct(ProductDTO updateProduct);
        Task DeleteProduct(Guid ID);
    }
}