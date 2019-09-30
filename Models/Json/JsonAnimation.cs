using Newtonsoft.Json;

namespace Hrothgar.Tiled
{
    internal class JsonAnimation
    {
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("tileid")]
        public int TileId { get; set; }
    }
}
