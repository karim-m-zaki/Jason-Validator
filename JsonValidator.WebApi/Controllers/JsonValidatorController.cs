using JsonValidator.WebApi.Models;
using JsonValidator.WebApi.Services;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JsonValidator.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:51366", "*", "*")]
    public class JsonValidatorController : ApiController
    {
        //Action method "POST" that calidates JSON and return bool, string as a Tuple
        [HttpPost]
        [Route("api/jsonvalidator")]
        public Tuple<bool, string> JsonValidator(JsonInputDto input)
        {
            ValidatorService s = new ValidatorService();
            var output = s.JsonValidator(input.JsonData);
            return Tuple.Create(output.Item1, output.Item2);
        }
    }
}