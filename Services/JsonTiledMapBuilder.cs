using Newtonsoft.Json;
using System.IO;

namespace Hrothgar.Tiled
{
    internal class JsonTiledMapBuilder : TiledMapBuilder
    {
        private const string tsx = ".tsx";
        private const string json = ".json";
        public JsonTiledMapBuilder(string basePath) : base(basePath) { }

        public override TiledMap Load(string mapName)
        {
            TiledMap returnVal;
            JsonMap jsonMap = JsonConvert.DeserializeObject<JsonMap>(File.ReadAllText($"{BasePath}{mapName}"));
            returnVal = jsonMap.ToTiledMap();
            foreach(var layer in jsonMap.Layers)
            {
                returnVal.Layers.Add(layer.ToTiledLayer());
            }
            foreach(var tileSet in jsonMap.TileSets)
            {                
                tileSet.TileSheet = JsonConvert.DeserializeObject<JsonTileSheet>
                    (File.ReadAllText($"{BasePath}{tileSet.Source.Replace(tsx, json)}"));
                var ts = tileSet.ToTiledTileSet();
                returnVal.TileSets.Add(ts);
            }
            return returnVal;
        }
    }
}
