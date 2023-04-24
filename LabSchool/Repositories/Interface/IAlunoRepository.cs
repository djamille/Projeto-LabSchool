using LabSchool.Models;

namespace LabSchool.Repositories.Interface;

public interface IAlunoRepository
{
    void Create(Aluno aluno);
    List<Aluno> List();
    Aluno? GetById(int Cod);
    void Update(Aluno aluno);
    void Delete(int Cod);
}
