using Microsoft.AspNetCore.Mvc;
using webapentityframeworkdocker.Models;

namespace webapentityframeworkdocker.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly SalesContext _salesContext;

        public ProductsController(SalesContext salesContext)
        {
            _salesContext = salesContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_salesContext.Products.OrderBy(p => p.ProductId));
        }
    }
}
