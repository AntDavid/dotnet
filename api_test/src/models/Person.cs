using System.Collections.Generic;
using Microsoft.AspNetCore.Localization;

namespace src.Models;

public class Person
{   
    int LastId = 0;

    public int id { get; }
    public string Nome { get; set;}
    
    public int Idade {get; set;}

    public string? Cpf {get; set;}

    public bool Ativado {get; set;}

    public List<Contract> Contractos {get; set;}

    public Person()
    {
        this.Nome = "template";
        this.Idade = 0;
        this.Contractos = new List<Contract>();
        this.Ativado = true;
    }

    public Person(string Nome, int Idade, string Cpf, bool Ativado)
    {
        this.id = LastId++;
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cpf = Cpf;
        this.Ativado = Ativado;
        this.Contractos = new List<Contract>();

    }
}

