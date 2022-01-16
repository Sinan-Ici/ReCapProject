using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _colorService.GetAll();
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            
            var result = _colorService.GetById(id);
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addcolor")]
        public IActionResult Add(Color color)
        {
                
            var result = _colorService.Add(color);
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
