using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOModels;
using WebApi.Logic;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductLogic _productLogic;
        public ProductController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet("/getproducts")]
        public async Task<List<ProductDTO>> GetProductsAsync()
        {
            return await _productLogic.GetProducts();
        }

        [HttpGet("/getproduct/id")]
        public async Task<ProductDTO> GetProductAsync(Guid ID)
        {
            return await _productLogic.GetProduct(ID);
        }

        [HttpPost]
        public async Task CreateProductAsync(ProductDTO product)
        {
            await _productLogic.CreateProduct(product);
        }

        [HttpPut]
        public async Task EditProductAsync(Guid ID, ProductDTO product)
        {
            await _productLogic.EditProduct(ID, product);
        }

        [HttpDelete]
        public async Task DeleteProductAsync(Guid ID)
        {
            await _productLogic.DeleteProduct(ID);
        }
    }
}