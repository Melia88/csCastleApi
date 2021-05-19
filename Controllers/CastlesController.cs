using System;
using System.Collections.Generic;
using csCastleApi.Models;
using csCastleApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace csCastleApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CastlesController : ControllerBase
  {
    private readonly CastlesService _service;

    public CastlesController(CastlesService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Castle>> GetAll()
    {
      try
      {
        IEnumerable<Castle> castles = _service.GetAll();
        return Ok(castles);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}