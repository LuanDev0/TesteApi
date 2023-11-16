using Microsoft.AspNetCore.Mvc;

namespace Teste.controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/Mundo")]
        public string Get()
        {
             using(var Context = new AppDbContexto())
             {
                
             }
            return "Olá Mundo";
        }
    }
}