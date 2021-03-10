using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OpenApiDiscoverability.Webapi.Controllers
{
    /// <summary>
    /// https://devblogs.microsoft.com/aspnet/creating-discoverable-http-apis-with-asp-net-core-5-web-api/?WT.mc_id=dotnet-13135-jogallow
    /// </summary>
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("api/shops")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class ShopController : ControllerBase
    {
        // operationId is defined as an optional unique string used to identify an operation
        // Name = nameof(GetShops) defines this operationId (and needs to be unique)
        [HttpGet(Name = nameof(GetShops))]
        public IEnumerable<string> GetShops()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}", Name = nameof(Get))]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost(Name = nameof(Post))]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}", Name = nameof(Put))]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}", Name = nameof(Delete))]
        public void Delete(int id)
        {
        }
    }
}
