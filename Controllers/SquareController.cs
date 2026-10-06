using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(Getnum num)
    {
        return num.num*num.num;
    }
}
public class Getnum
{
    public int num{get;set;}
}
