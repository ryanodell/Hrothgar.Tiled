using Newtonsoft.Json;

namespace Hrothgar.Tiled
{
    internal class JsonTileSheet
    {
        [JsonProperty("columns")]
        public int Columns { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageheight")]
        public int ImageHeight { get; set; }

        [JsonProperty("imagewidth")]
        public int ImageWidth { get; set; }

        [JsonProperty("margin")]
        public int Margin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spacing")]
        public int Spacing { get; set; }

        [JsonProperty("tilecount")]
        public int TileCount { get; set; }

        [JsonProperty("tiledversion")]
        public string TiledVersion { get; set; }

        [JsonProperty("tileheight")]
        public int TileHeight { get; set; }

        [JsonProperty("tiles")]
        public JsonTile[] Tiles { get; set; }

        [JsonProperty("tilewidth")]
        public int TileWidth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public float Version { get; set; }
    }
}
