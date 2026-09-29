using Microsoft.AspNetCore.Mvc;

namespace Products.API.Controllers;

public record ProductRequest(string Name, decimal Price);
public record Product(int Id, string Name, decimal Price);

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new();
    private static int _nextId = 1;

    [HttpGet]
    public IActionResult GetAll() => Ok(_products);

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public IActionResult Create(ProductRequest request)
    {
        var product = new Product(_nextId++, request.Name, request.Price);
        _products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }
}