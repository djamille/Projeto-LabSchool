using LabSchool.Context;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]
[Route("[controller]")]
public class PedagogoController : ControllerBase
{
    private readonly LabSchoolContext _context;

    public PedagogoController(LabSchoolContext context)            //Injeção de dependencia
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var pedagogo = _context.Pedagogos.ToList();
        return Ok(pedagogo);
    }
}



