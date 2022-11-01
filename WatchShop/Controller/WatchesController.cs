using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchesShop.Model;
using WatchesShop.Services;

namespace WatchesShop.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class WatchesController : ControllerBase
    {

        JsonWatchesFile WatchesService { get; }

        public WatchesController(JsonWatchesFile watchesService)
        {
            this.WatchesService = watchesService;
        }
        [HttpGet]
        public IEnumerable<Watches> Get()
        {
          return WatchesService.getWatchesRecords();
        }
    }
}
