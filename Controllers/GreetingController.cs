using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(Getuser user)
    {
        return $"Hello {user.name}!";
    }
}
public class Getuser
{
    public  string name{get;set;}
}