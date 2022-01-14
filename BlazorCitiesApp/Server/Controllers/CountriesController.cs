using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCitiesApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        // Te benaderen op URL https://localhost:1234/api/countries

        public List<string> Get()
        {
            return new List<string> { "Nederland", "Belgie", "Duitsland", "Engeland", "Frankrijk", "Spanje" };
        }

    }
}
