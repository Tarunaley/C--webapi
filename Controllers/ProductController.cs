using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Get()
    {
        return new Product{id=1,name="Laptop",price=75000,brand="Dell"};
    }
    
}
public class Product
{
    public int id{get;set;}
    public string name{get;set;}
    public int price{get;set;}
    public string brand{get;set;}

}