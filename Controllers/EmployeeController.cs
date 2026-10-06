using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public Getdetails Post(Getid id)
    {
        if (id.id == 101)
        {
            return new Getdetails(101, "Rahul", "IT");
        }
        else
        {
            return new Getdetails(0, "Employee not found", "");
        }
    }
}

public sealed record Getid(int id);

public sealed record Getdetails(
    int id,
    string name,
    string department
);
