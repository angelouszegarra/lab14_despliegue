using Microsoft.AspNetCore.Mvc;
using Lab14_AngelousZegarra.Models;

namespace Lab14_AngelousZegarra.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly Lab14dbContext _context;

    public ProductosController(Lab14dbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Productos.ToList());
    }
}