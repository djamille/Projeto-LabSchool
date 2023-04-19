using LabSchool.Models;

namespace LabSchool.Repositories.Interface;

public interface IPedagogoRepository
{
    List<Pedagogo> List();
    Pedagogo? GetById(int Cod);
    void Update(Pedagogo pedagogo);
}
