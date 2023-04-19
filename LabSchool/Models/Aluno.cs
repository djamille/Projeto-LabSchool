using LabSchool.Enums;

namespace LabSchool.Models;

public class Aluno : Pessoa
{
    public ESituacaoMatricula Situacao { get; set; }
    public float Nota { get; set; }
    public int QtdAtendimento{ get; set; }

    public void Atendimento()
    {
        Situacao = ESituacaoMatricula.ATENDIMENTO_PEDAGOGICO;
        QtdAtendimento++;
    }
}