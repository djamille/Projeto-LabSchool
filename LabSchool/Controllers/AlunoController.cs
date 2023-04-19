using LabSchool.Context;
using LabSchool.Dtos;
using LabSchool.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly LabSchoolContext _context;            //Injeção de dependencia - 

    public AlunoController(LabSchoolContext context)
    {
        _context = context;
    }
        
    //Endpoint CRIAR
    [HttpPost]
    public IActionResult Create([FromBody] AlunoCriarEntDto alunoDto)
    {
        
        var alunoEntrada = new Aluno();
        alunoEntrada.Nome = alunoDto.Nome;
        alunoEntrada.Telefone = alunoDto.Telefone;
        alunoEntrada.DataNascimento = alunoDto.DataNascimento;
        alunoEntrada.CPF = alunoDto.CPF;
        alunoEntrada.Situacao = alunoDto.Situacao;
        alunoEntrada.Nota = alunoDto.Nota;

        _context.Alunos.Add(alunoEntrada);
        _context.SaveChanges();


        var alunoDtoSaida = new AlunoSaidaDto();
        alunoDtoSaida.Cod = alunoEntrada.Cod;
        alunoDtoSaida.Nome = alunoEntrada.Nome;
        alunoDtoSaida.Telefone = alunoEntrada.Telefone;
        alunoDtoSaida.DataNascimento = alunoEntrada.DataNascimento;
        alunoDtoSaida.CPF = alunoEntrada.CPF;
        alunoDtoSaida.Situacao = alunoEntrada.Situacao;
        alunoDtoSaida.Nota = alunoEntrada.Nota;
        alunoDtoSaida.QtdAtendimento = alunoEntrada.QtdAtendimento;

        return Ok(alunoDtoSaida);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{Situacao}")]
    public IActionResult Update(int Cod, [FromBody] AlunoAtualizarEntDto alunoDto)
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));
        if (aluno == null)
            return NotFound();
        
        aluno.Situacao = alunoDto.Situacao;

        _context.Alunos.Update(aluno);
        _context.SaveChanges();

        var alunoDtoSaida = new AlunoSaidaDto();
        alunoDtoSaida.Cod = aluno.Cod;
        alunoDtoSaida.Nome = aluno.Nome;
        alunoDtoSaida.Telefone = aluno.Telefone;
        alunoDtoSaida.DataNascimento = aluno.DataNascimento;
        alunoDtoSaida.CPF = aluno.CPF;
        alunoDtoSaida.Situacao = aluno.Situacao;
        alunoDtoSaida.Nota = aluno.Nota;
        alunoDtoSaida.QtdAtendimento = aluno.QtdAtendimento;

        return CreatedAtAction(nameof(AlunoController.Get), new { Cod = aluno.Cod }, alunoDtoSaida);
    }


    //Endpoint Consultar
    [HttpGet]
    public IActionResult Get()
    {
        var alunos = _context.Alunos.ToList();
        return Ok(alunos);
    }
    

    //Endpoint Consultar por Cod
    [HttpGet]
    [Route("{Cod}")]
    public IActionResult GetByCod(int Cod)
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));
        if (aluno == null)
        {
            return NotFound();
        }
        return Ok(aluno);
    }

        
    [HttpDelete]
    public IActionResult Delete (int Cod)
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));
        if (aluno == null)
        {
            return NotFound();
        }

        _context.Alunos.Remove(aluno);
        _context.SaveChanges();

        return NoContent();
    }    
}