using LabSchool.Enums;

namespace LabSchool.Models;

public class Aluno : Pessoa                     //Classe herda de classe Pessoa
{
    public ESituacaoMatricula Situacao { get; set; }                     //Atributos requisitados
    public float Nota { get; set; }
    public int QtdAtendimento{ get; set; }

    public void Atendimento()
    {
        Situacao = ESituacaoMatricula.ATENDIMENTO_PEDAGOGICO;
        QtdAtendimento++;
    }
}