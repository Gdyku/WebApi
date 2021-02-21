using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebApi.DTOModels;
using AutoMapper;
using System.Threading;

namespace WebApi.Logic
{
    public class ProductLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ProductLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            var mappedProducts = _mapper.Map<List<Product>, List<ProductDTO>>(products);

            return mappedProducts;
        }

        public async Task<ProductDTO> GetProduct(Guid ID)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ID == ID);
            var mappedproduct = _mapper.Map<Product, ProductDTO>(product);

            return mappedproduct;
        }

        public async Task CreateProduct(ProductDTO product)
        {
            var mappedProduct = _mapper.Map<ProductDTO, Product>(product);

            _context.Products.Add(mappedProduct);
            await _context.SaveChangesAsync();
        }

        public async Task EditProduct(Guid ID, ProductDTO updateProduct)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ID == ID);

            if (product == null)
                throw new Exception("Couldn't find product");

            product.Name = updateProduct.Name ?? product.Name;
            product.Price = updateProduct.Price ?? product.Price;
            product.Description = updateProduct.Description ?? product.Description;
            product.Category = updateProduct.Category ?? product.Category;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Guid ID)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ID == ID);

            _context.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}