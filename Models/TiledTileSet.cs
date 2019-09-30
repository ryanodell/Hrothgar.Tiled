using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    public class TiledTileSet
    {
        public int FirstgId { get; set; }
        public string Source { get; set; }
        public TiledTileSheet TileSheet { get; set; }
    }
}
