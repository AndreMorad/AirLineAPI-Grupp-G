﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AirLineAPI.Db_Context;

namespace AirLineAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly AirLineContext _context;

        public FlightsController(AirLineContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string Get()
        {
           //
        }
    }
}