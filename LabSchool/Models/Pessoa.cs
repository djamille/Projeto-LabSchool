namespace LabSchool.Models;

public abstract class Pessoa
{
    public int Cod { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
}
