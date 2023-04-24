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


    public void Create(Aluno aluno)                     //Metodo Criar Aluno
    {
        _context.Alunos.Add(aluno);
        _context.SaveChanges();
    }

    
    public List<Aluno> List()                     //Metodo Listar Aluno
    {
        return _context.Alunos.ToList();
    }
   

    public Aluno? GetById(int Codigo)                     //Metodo Obter por Codigo de Aluno
    {
        return _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Codigo));
    }


    public void Update(Aluno aluno)                     //Metodo Atualizr Aluno
    {
        _context.Alunos.Update(aluno);
        _context.SaveChanges();
    }


    public void Delete(int Cod)                     //Metodo Deletar Aluno
    {
        var aluno = GetById(Cod);
        _context.Alunos.Remove(aluno);
        _context.SaveChanges();
    }
}
