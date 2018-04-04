using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CuponAPI.Controllers
{
    [Route("api/[controller]")]
    public class CuponsController : Controller
    {
        /// <summary>
        /// GET api/cupons
        /// </summary>
        /// <param name="request">Empty</param>
        /// <returns>A ListCuponResponse object containing the list of all registered cupons.</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// GET api/cupons/:id
        /// </summary>
        /// <param name="id">The id of a cupon.</param>
        /// <returns>A CuponResponse with a registered cupon.</returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="cupon">The cupon code.</param>
        /// <returns>A PostCuponResponse containing a boolean for the operation and a reason if fails (already used or invalid).</returns>
        [HttpPost]
        public bool Post([FromBody]string cupon)
        {
            return false;
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        /// <summary>
        /// DELETE api/values/:id
        /// </summary>
        /// <param name="id">The id of a cupon.</param>
        /// <returns>A DeleteCuponResponse containing a boolean for the operation and a reason if fails (already used or invalid).</returns>
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return false;
        }
    }
}
