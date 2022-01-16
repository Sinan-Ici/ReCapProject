﻿using Business.Abstract;
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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _brandService.GetAll();
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            var result = _brandService.GetById(id);
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addbrand")]
        public IActionResult Add(Brand brand)
        {

            var result = _brandService.Add(brand);
            if (result.Succcess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}