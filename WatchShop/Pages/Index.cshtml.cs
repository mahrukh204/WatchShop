using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchesShop.Model;
using WatchesShop.Services;

namespace WatchShop.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Watches> watches { get; private set; }

        public JsonWatchesFile WatchesService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonWatchesFile watchesService)
        {
            _logger = logger;
            WatchesService = watchesService;
        }

       public void OnGet(object Watches)
        {
            
        }
    }
}
