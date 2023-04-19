using LabSchool.Context;
using LabSchool.Dtos;
using LabSchool.Models;
using LabSchool.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfessorController : ControllerBase
{
    private readonly LabSchoolContext _context;

    public ProfessorController(LabSchoolContext context) 
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var professores = _context.Professores.ToList();

        return Ok(professores);
    }
}