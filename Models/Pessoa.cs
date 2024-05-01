namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
        Console.WriteLine($"O hóspede {nome} foi cadastrado!\n");
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Console.WriteLine($"O hóspede {NomeCompleto} foi cadastrado!\n");
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}