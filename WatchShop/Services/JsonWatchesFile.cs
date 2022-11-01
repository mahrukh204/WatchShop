using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WatchesShop.Model;

namespace WatchesShop.Services
{
    public class JsonWatchesFile
    {
        public JsonWatchesFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "watches.json");
            }
        }

        public IEnumerable<Watches> getWatchesRecords()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Watches[]>(json_file.ReadToEnd());
            }
        }

        internal void setWatchesRecords(Watches obj, JsonWatchesFile watchesService)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Watches> getWatchesRecord()
        {
            throw new NotImplementedException();
        }
    }
}
