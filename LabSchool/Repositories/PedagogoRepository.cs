using LabSchool.Context;
using LabSchool.Models;
using LabSchool.Repositories.Interface;

namespace LabSchool.Repositories;

public class PedagogoRepository : IPedagogoRepository
{
    private readonly LabSchoolContext _context;

    public PedagogoRepository(LabSchoolContext context)
    {
        _context = context;
    }


    public List<Pedagogo> List()                     //Metodo Listar Pedagogo
    {
        return _context.Pedagogos.ToList();
    }


    public Pedagogo? GetById(int codigo)                     //Metodo Obter por Codigo de Pedagogo
    {
        return _context.Pedagogos.FirstOrDefault(x => x.Cod.Equals(codigo));
    }


    public void Update(Pedagogo pedagogo)                     //Metodo Atualizar Pedagogo
    {
        _context.Pedagogos.Update(pedagogo);
        _context.SaveChanges();
    }
}

