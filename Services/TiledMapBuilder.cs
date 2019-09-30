using System;
using System.Collections.Generic;
using System.Text;

namespace Hrothgar.Tiled
{
    internal abstract class TiledMapBuilder
    {
        public string BasePath { get; private set; }
        public TiledMapBuilder(string basePath)
        {
            BasePath = basePath;
        }

        public abstract TiledMap Load(string mapName);
    }
}
