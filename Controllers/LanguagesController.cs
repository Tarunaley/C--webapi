using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Controllers;
[ApiController]
[Route("[controller]")]
public class LanguagesController : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        var Lanuages=new List<string>
        {
             "C#",
        "Java",
        "Python",
    "JavaScript",
    "Go"
        };
        return Lanuages;
    }
}
