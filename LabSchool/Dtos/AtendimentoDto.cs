using System.ComponentModel.DataAnnotations;

namespace LabSchool.Dtos;

public class AtendimentoEntDto
{
    [Required(ErrorMessage = "O campo Código do Aluno é obrigatório.")]
    public int CodigoAluno { get; set; }

    [Required(ErrorMessage = "O campo Código do Atendimento é obrigatório.")]
    public int CodigoPedagogo { get; set; }
}
