using System;

namespace Hrothgar.Tiled
{
    public class TiledMapLoader
    {
        public eLoadType LoadType { get; private set; }
        public string LoadPath { get; private set; }
        private TiledMapBuilder tiledMapBuilder;

        public TiledMapLoader(eLoadType loadType)
        {
            LoadType = loadType;
            tiledMapBuilder = _getByLoadType(loadType);
        }
        public TiledMapLoader(eLoadType loadType, string loadPath)
        {
            LoadType = loadType;
            LoadPath = loadPath;
            tiledMapBuilder = _getByLoadType(loadType);
        }

        public TiledMap LoadMap(string mapName)
        {
            return tiledMapBuilder.Load(mapName);
        }

        private TiledMapBuilder _getByLoadType(eLoadType loadType)
        {
            TiledMapBuilder tiledMapBuilder = null;
            switch (loadType)
            {
                case eLoadType.RawJson:
                    tiledMapBuilder = new JsonTiledMapBuilder(LoadPath);
                    break;
                case eLoadType.Tmx:
                case eLoadType.ContentPipelin:
                    break;
                default:
                    break;
            }
            if (tiledMapBuilder == null)
            {
                throw new NotImplementedException($"Load Type: {loadType} is not implemented.");
            }
            return tiledMapBuilder;
        }
    }
}
