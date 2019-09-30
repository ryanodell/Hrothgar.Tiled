using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    public class TiledTileSheet
    {
        public int Columns { get; set; }
        public string Image { get; set; }
        public int ImageHeight { get; set; }
        public int ImageWidth { get; set; }
        public int Margin { get; set; }
        public string Name { get; set; }
        public int Spacing { get; set; }
        public int TileCount { get; set; }
        public string TiledVersion { get; set; }
        public int TileHeight { get; set; }
        public List<TiledTile> Tiles { get; set; } = new List<TiledTile>();
        public int TileWidth { get; set; }
        public string Type { get; set; }
        public float Version { get; set; }

        public static implicit operator TiledTileSheet(List<TiledTileSheet> v)
        {
            throw new NotImplementedException();
        }
    }
}
