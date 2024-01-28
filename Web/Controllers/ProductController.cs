using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProductDTO productDTO)
    {
        await _productService.Add(productDTO);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put(ProductDTO productDTO)
    {
        await _productService.Update(productDTO);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Remove(int? id)
    {
        await _productService.Remove(id);
        return Ok();
    }

    [HttpGet("All")]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productService.GetProductsAsync();
        return Ok(products);
    }

    [HttpGet("ById")]
    public async Task<IActionResult> GetById(int? id)
    {
        var products = await _productService.GetProductByIdAsync(id);
        return Ok(products);
    }
}
