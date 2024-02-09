using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
    {
        var productsEntity = await _productRepository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
    }

    public async Task<ProductDTO> GetProductByIdAsync(int? id)
    {
        var productEntity = await _productRepository.GetProductByIdAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }
    public async Task Add<T>(T entityDTO) where T : class
    {
        var productEntity = _mapper.Map<Product>(entityDTO);
        await _productRepository.Add(productEntity);
    }

    public async Task Update<T>(T entityDTO) where T : class
    {
        var productEntity = _mapper.Map<Product>(entityDTO);
        await _productRepository.Update(productEntity);
    }

    public async Task Delete(int? id)
    {
        var productEntity = _productRepository.GetProductByIdAsync(id).Result;
        await _productRepository.Remove(productEntity);
    }
}
