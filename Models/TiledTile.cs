using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    public class TiledTile
    {
        public List<TiledAnimation> Animation { get; set; } = new List<TiledAnimation>();
        public int Id { get; set; }
    }
}
