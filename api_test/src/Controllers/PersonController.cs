using Microsoft.AspNetCore.Mvc;
using src.Models;


namespace src.Controllers;


[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{

    [HttpGet]

    public Person Get()
    {
        Person pessoa = new Person("Antonio", 22, "08608986523", true);
        pessoa.Contractos.Add(new Contract("a9sdjakldjald", 20000.00));
        pessoa.Contractos.Add(new Contract("9asdaus0asudu0au0du1", 90000.00));

        return pessoa;
    }

    [HttpPost]
    public Person Post([FromBody]Person person){

        return person;
    }
    [HttpPut("{id}")]

    public string Update([FromRoute]int id, [FromBody]Person person){
        Console.WriteLine("id: " + id);
        Console.WriteLine("pessoa: " + person.Nome);
        return "dados do id " + id + " atualizados";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute]int id)
    {
        return "dados do id " + id + " deletados";
    }


}