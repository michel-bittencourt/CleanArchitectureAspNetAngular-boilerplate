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

    #region Metodos
    [HttpPost]
    // FromBody diz que os dados serao passados no corpo do request
    public async Task<ActionResult> Post([FromBody] ProductDTO productDTO)
    {
        if (productDTO != null)
        {
            await _productService.Add(productDTO);
            return Ok(productDTO);
        }
        return BadRequest();
    }

    [HttpPut]
    public async Task<ActionResult> Put(ProductDTO productDTO)
    {
        await _productService.Update(productDTO);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ProductDTO>> Remove(int? id)
    {
        await _productService.Delete(id);

        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAll()
    {
        var products = await _productService.GetProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id:int}" , Name = "GetProduct")]
    public async Task<ActionResult<ProductDTO>> GetById(int? id)
    {
        var products = await _productService.GetProductByIdAsync(id);
        return Ok(products);
    }
    #endregion
}
