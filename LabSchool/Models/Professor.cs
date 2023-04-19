using LabSchool.Enums;

namespace LabSchool.Models;

public class Professor : Pessoa
{
    public EEstado Estado { get; set; }
    public EExperiencia Experiencia { get; set; }
    public EFormacaoAcademica Formacao { get; set; }
}
