using LabSchool.Enums;

namespace LabSchool.Models;

public class Professor : Pessoa                     //Classe herda de classe Pessoa
{
    public EEstado Estado { get; set; }                     //Enuns requisitados
    public EExperiencia Experiencia { get; set; }
    public EFormacaoAcademica Formacao { get; set; }
}
