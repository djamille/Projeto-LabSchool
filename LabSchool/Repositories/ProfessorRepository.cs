using LabSchool.Context;
using LabSchool.Models;
using LabSchool.Repositories.Interface;

namespace LabSchool.Repositories;

public class ProfessorRepository : IProfessorRepository
{
    private readonly LabSchoolContext _context;

    public ProfessorRepository(LabSchoolContext context)
    {
        _context = context;
    }

    public List<Professor> List()
    {
        return _context.Professores.ToList();
    }
}
