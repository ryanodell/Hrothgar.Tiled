using Newtonsoft.Json;

namespace Hrothgar.Tiled
{
    internal class JsonMap
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("tilewidth")]
        public int TileWidth { get; set; }

        [JsonProperty("tileheight")]
        public int TileHeight { get; set; }

        [JsonProperty("nextlayerid")]
        public int NextLayerId { get; set; }

        [JsonProperty("nextobjectid")]
        public int NextObjectId { get; set; }

        [JsonProperty("tilesets")]
        public JsonTileSet[] TileSets { get; set;}

        [JsonProperty("layers")]
        public JsonLayer[] Layers { get; set; }
    }
}
