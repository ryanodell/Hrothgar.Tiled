using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    public class TiledMap
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int TileWidth { get; set; }

        public int TileHeight { get; set; }

        public int NextLayerId { get; set; }

        public int NextObjectId { get; set; }

        public List<TiledTileSet> TileSets { get; set; } = new List<TiledTileSet>();

        public List<TiledLayer> Layers { get; set; } = new List<TiledLayer>();
    }
}
