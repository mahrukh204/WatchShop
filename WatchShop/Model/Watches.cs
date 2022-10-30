using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchesShop.Model
{
    public class Watches
    {
        [JsonPropertyName("id")]
        public int watch_id { get; set; }

        [JsonPropertyName("name")]
        public string watch_name { get; set; }

        [JsonPropertyName("image")]
        public string watch_image { get; set; }

        public override string ToString()
        {
            Watches watches = this;
            return JsonSerializer.Serialize<Watches>(this);
        }

    }
}
