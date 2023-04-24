using LabSchool.Context;
using LabSchool.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]                      //Indicativo de que a classe é uma controller
[Route("[controller]")]                         //Customização de url
public class AtendimentoController : Controller
{
    private readonly LabSchoolContext _context;
    public AtendimentoController(LabSchoolContext context)            //Injeção de dependencia - 
    {
        _context = context;
    }

    [HttpPut]
    public IActionResult Update([FromBody] AtendimentoEntDto atendimentoEntDto)                             //Criando EndPoint. 'IActionResult' é utilizado pois varios podem ser o tipo de retorno válido 
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(atendimentoEntDto.CodigoAluno));                           //Chamando método
        if (aluno == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        

        var pedagogo = _context.Pedagogos.FirstOrDefault(x => x.Cod.Equals(atendimentoEntDto.CodigoPedagogo));                           //Chamando método
        if (pedagogo == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }


        aluno.Atendimento();

        _context.Alunos.Update(aluno);                           //Chamando metodo
        _context.SaveChanges();                           //Salvando

        pedagogo.Atendimento();

        _context.Pedagogos.Update(pedagogo);                           //Chamando metodo
        _context.SaveChanges();                           //Salvando

        return Ok(new { aluno, pedagogo });
        
    }
}