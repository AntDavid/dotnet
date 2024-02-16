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
        return pessoa;
    }

}