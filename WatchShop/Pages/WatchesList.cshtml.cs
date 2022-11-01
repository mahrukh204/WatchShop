using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WatchesShop.Model;
using WatchesShop.Services;

namespace WatchesShop.Pages
{
    public class WatchesListModel : PageModel
    {
        JsonWatchesFile watchesService;
        public IEnumerable<Watches> Watches;
        
        public WatchesListModel(JsonWatchesFile watchesService)
        {
            this.watchesService = watchesService;
        }

        public void OnGet()
        {
            Watches = WatchesService.getWatchesRecords();
        }
    }
}
