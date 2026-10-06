using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Controllers;

public class Student
{
    public int id{get;set;}
    public string name{get;set;}
    public string course{get;set;}
    public int age{get;set;}
}
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public Student Get()
    {
        return new Student{id=201,name="Tarun",course="B.tech",age=20};
        
    }

}