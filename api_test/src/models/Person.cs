namespace src.Models;

public class Person
{
    public string Nome { get; set;}
    
    public int Idade {get; set;}

    public string Cpf {get; set;}

    public bool Ativado {get; set;}



    public Person()
    {
        this.Nome = "template";
        this.Idade = 0;
    }

    public Person(string Nome, int Idade, string Cpf, bool Ativado)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cpf = Cpf;
        this.Ativado = Ativado;
    }
}

