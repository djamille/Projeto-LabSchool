using System.ComponentModel.DataAnnotations;
using LabSchool.Enums;

namespace LabSchool.Dtos;


public class AlunoCriarEntDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(80, MinimumLength = 8, ErrorMessage = "Intervalo permitido de 8 a 80 caracteres. ")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MinLength(8, ErrorMessage = "{0} deve ter no minímo 8 caracteres ")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório. ")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório. ")]
    [StringLength(14, MinimumLength = 11, ErrorMessage = "Intervalo permitido de 11 a 14 caracteres. ")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório. ")]
    [Range(0, 4, ErrorMessage = "A {0} deve ser entre 0 e 4.")]
    public ESituacaoMatricula Situacao { get; set; }

    [Required()]
    [Range(0, 10, ErrorMessage = "A {0} deve ser entre 0 e 10.")]
    public float Nota { get; set; }
}

    
public class AlunoAtualizarEntDto
{
    [Required()]
    [Range(0, 3,ErrorMessage = "Escolha uma das situações da matrícula: 0 - atendimento pedagógico, 1 - ativo, 2 - irregular e 3 - inativo.")]
    public ESituacaoMatricula Situacao { get; set; }
}

public class AlunoSaidaDto
{
    public int Cod { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public ESituacaoMatricula Situacao { get; set; }
    public float Nota { get; set; }
    public int QtdAtendimento { get; set; }
}