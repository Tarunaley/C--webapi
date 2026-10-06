using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class DetailsController : ControllerBase
{
    [HttpPost]
    public Getconfirmation Post(Getdetailss details)
    {
        return new Getconfirmation("Student created successfully",details.name,details.age,details.course);
    }
}
public sealed record Getdetailss(string name,int age,string course);
public sealed record Getconfirmation(string message,string name,int age,string course);
