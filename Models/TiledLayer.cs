using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    public class TiledLayer
    {
        public int[] Data { get; set; }

        public int Height { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public bool Visible { get; set; }

        public int Width { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
