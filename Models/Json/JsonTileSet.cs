using Newtonsoft.Json;

namespace Hrothgar.Tiled
{
    internal class JsonTileSet
    {
        [JsonProperty("firstgid")]
        public int FirstgId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        public JsonTileSheet TileSheet { get; set; }
    }
}
