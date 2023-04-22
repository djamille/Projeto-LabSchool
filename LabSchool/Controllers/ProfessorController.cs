using LabSchool.Context;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]                      //Indicativo de que a classe é uma controller
[Route("[controller]")]                         //Customização de url
public class ProfessorController : ControllerBase
{
    private readonly LabSchoolContext _context;

    public ProfessorController(LabSchoolContext context)             //Injeção de dependencia - 
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()                       //Este endpoint fara uma lista de professores
    {
        var professores = _context.Professores.ToList();                           //Chamando método
        if (professores == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(professores);                     //Senão retorna o resultado solicitado
    }
}