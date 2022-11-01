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
    public class FormHandlerController : ControllerBase
    {

        JsonWatchesFile WatchesService;
        public FormHandlerController(JsonWatchesFile watchesService)
        {
            this.WatchesService = watchesService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Watches obj = new Watches();
            obj.watches_id = id;
            obj.watches_name = name;
            obj.watches_image = image;


            WatchesService.setWatchesRecords(obj, WatchesService);
            return "Function Exec";
        }
    }
}
