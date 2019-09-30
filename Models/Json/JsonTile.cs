using Newtonsoft.Json;

namespace Hrothgar.Tiled
{
    internal class JsonTile
    {
        [JsonProperty("animation")]
        public JsonAnimation[] Animation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
