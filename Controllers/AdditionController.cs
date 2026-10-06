using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class AdditionController : ControllerBase
{
    [HttpPost]
    public int Post(GetNumbers numbers)
    {
        return numbers.num1+numbers.num2;
    }
}
public sealed record GetNumbers(int num1,int num2);
