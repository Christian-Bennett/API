using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MovieInfo.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  [EnableCors()]
  public class SWController : ControllerBase
  {
    private static readonly List<SWModel> _swml = new List<SWModel>();

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_swml); // response message = data + http status code
    }

    [HttpPost]
    public IActionResult Post(SWModel model)
    {
      if (ModelState.IsValid)
      {
        _swml.Add(model);
        return Ok();
      }

      return BadRequest(model);
    }

    [HttpPut]
    public void Put(int id)
    {

    }

    [HttpDelete]
    public void Delete(int id)
    {

    }
  }
}