using LabSchool.Context;
using LabSchool.Dtos;
using LabSchool.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]                      //Indicativo de que a classe é uma controller
[Route("[controller]")]                         //Customização de url
public class AlunoController : ControllerBase                               //Uma classe que deriva de ControllerBase serve para manipulação de páginas da Web
{
    private readonly LabSchoolContext _context;

    public AlunoController(LabSchoolContext context)            //Injeção de dependencia - 
    {
        _context = context;
    }

    //Endpoint CRIAR
    [HttpPost]
    public IActionResult Create([FromBody] AlunoCriarEntDto alunoDto)
    {
        
        var alunoEntrada = new Aluno();                         //Informações que api ira receber
        alunoEntrada.Nome = alunoDto.Nome;
        alunoEntrada.Telefone = alunoDto.Telefone;
        alunoEntrada.DataNascimento = alunoDto.DataNascimento;
        alunoEntrada.CPF = alunoDto.CPF;
        alunoEntrada.Situacao = alunoDto.Situacao;
        alunoEntrada.Nota = alunoDto.Nota;

        try
        {
            _context.Alunos.Add(alunoEntrada);
            _context.SaveChanges();                         //Salva informações fornecidas
        }
        catch (Exception excep) 
        {
            return Conflict("CPF já cadastrado");                       //Retorna mensagem caso haja conflito
        }

        var alunoDtoSaida = new AlunoSaidaDto();                         //Informações que api ira retornar
        alunoDtoSaida.Codigo = alunoEntrada.Cod;
        alunoDtoSaida.Nome = alunoEntrada.Nome;
        alunoDtoSaida.Telefone = alunoEntrada.Telefone;
        alunoDtoSaida.DataNascimento = alunoEntrada.DataNascimento;
        alunoDtoSaida.CPF = alunoEntrada.CPF;
        alunoDtoSaida.Situacao = alunoEntrada.Situacao;
        alunoDtoSaida.Nota = alunoEntrada.Nota;
        alunoDtoSaida.Atendimento = alunoEntrada.QtdAtendimento;

        return Ok(alunoDtoSaida);                     //Retorna o resultado solicitado
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{Situacao}")]                       //Este endpoint fara uma busca pelo cod, achando-o ira alterar somente a inform,ação liberada para acesso do usuario.
    public IActionResult Update(int Cod, [FromBody] AlunoAtualizarEntDto alunoDto)                             //Criando EndPoint. 'IActionResult' é utilizado pois varios podem ser o tipo de retorno válido 
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));                     //Nomeando variável e chamando método
        if (aluno == null)                     //Se for nulo retorna erro
            return NotFound();
        
        aluno.Situacao = alunoDto.Situacao;

        _context.Alunos.Update(aluno);                           //Chamando metodo
        _context.SaveChanges();                           //Salvando

        var alunoDtoSaida = new AlunoSaidaDto();                         //Informações que api ira retornar
        alunoDtoSaida.Codigo = aluno.Cod;
        alunoDtoSaida.Nome = aluno.Nome;
        alunoDtoSaida.Telefone = aluno.Telefone;
        alunoDtoSaida.DataNascimento = aluno.DataNascimento;
        alunoDtoSaida.CPF = aluno.CPF;
        alunoDtoSaida.Situacao = aluno.Situacao;
        alunoDtoSaida.Nota = aluno.Nota;
        alunoDtoSaida.Atendimento = aluno.QtdAtendimento;

        return CreatedAtAction(nameof(AlunoController.Get), new { Cod = aluno.Cod }, alunoDtoSaida);                    //Retorna o objeto
    }


    //Endpoint Consultar
    [HttpGet]
    public IActionResult Get()                       //Este endpoint fara uma lista de alunos
    {
        var alunos = _context.Alunos.ToList();                  //Chamando método
        if (alunos == null)                     //Se for nulo retorna erro
            return NotFound();

        return Ok(alunos);                     //Retorna o resultado solicitado
    }
    

    //Endpoint Consultar por Cod
    [HttpGet]
    [Route("{Cod}")]
    public IActionResult GetByCod(int Cod)                       //Este endpoint fara uma busca pelo cod, retornando o ewncontrado
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));                           //Chamando método
        if (aluno == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(aluno);                     //Senão retorna o resultado solicitado
    }

        
    [HttpDelete]
    public IActionResult Delete (int Cod)                       //Este endpoint fara uma busca pelo cod, achando-o ira deletar o usuario.
    {
        var aluno = _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));
        if (aluno == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }

        _context.Alunos.Remove(aluno);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();                         //O servidor atendeu à solicitação com êxito e não há conteúdo adicional a ser enviado na resposta
    }    
}