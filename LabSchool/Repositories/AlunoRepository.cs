using LabSchool.Context;
using LabSchool.Models;
using LabSchool.Repositories.Interface;


namespace LabSchool.Repositories;

public class AlunoRepository : IAlunoRepository
{
    private readonly LabSchoolContext _context;

   
    public AlunoRepository(LabSchoolContext context)
    {
        _context = context;
    }


    public void Create(Aluno aluno)
    {
        _context.Alunos.Add(aluno);
        _context.SaveChanges();
    }

    
    public List<Aluno> List()
    {
        return _context.Alunos.ToList();
    }
   

    public Aluno? GetById(int Codigo)
    {
        return _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Codigo));
    }


    public void Update(Aluno aluno)
    {
        _context.Alunos.Update(aluno);
        _context.SaveChanges();
    }


    public void Delete(int Cod)
    {
        var aluno = GetById(Cod);
        _context.Alunos.Remove(aluno);
        _context.SaveChanges();

    }
}
