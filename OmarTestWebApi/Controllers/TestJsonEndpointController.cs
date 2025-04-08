using Microsoft.AspNetCore.Mvc;

namespace OmarTestWebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class TestJsonEndpointController
    {
        [Route("notify/Pension")]
        [Route("notify/UKPayment")]
        [Route("notify/UKPension")]
        [Route("notify/UKPensionHolder")]
        [Route("notify/EmployerTaxYear")]
        [Route("notify/UKTaxCode")]
        [HttpPost]
        public IResult UKPost(object? e)
        {
            Console.WriteLine(e);

            if (e == null)
            {
                return Results.Ok();
            }

            return Results.Json(e);
        }
    }
}
