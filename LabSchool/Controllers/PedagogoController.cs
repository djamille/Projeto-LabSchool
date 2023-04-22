using LabSchool.Context;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]                      //Indicativo de que a classe é uma controller
[Route("[controller]")]                         //Customização de url
public class PedagogoController : ControllerBase
{
    private readonly LabSchoolContext _context;

    public PedagogoController(LabSchoolContext context)            //Injeção de dependencia
    {
        _context = context;
    }

    [HttpGet]                       //Este endpoint fara uma lista de pedagogos
    public IActionResult Get()
    {
        var pedagogo = _context.Pedagogos.ToList();                           //Chamando método
        if (pedagogo == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(pedagogo);                     //Senão retorna o resultado solicitado
    }
}



