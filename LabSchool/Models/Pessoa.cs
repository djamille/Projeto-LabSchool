namespace LabSchool.Models;

public abstract class Pessoa                    //Classe abstrata, sera herança para outras classes
{
    public int Cod { get; set; }                    //Atributos requisitados
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
}
