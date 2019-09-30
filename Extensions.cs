namespace Hrothgar.Tiled
{
    internal static class Extensions
    {
        public static TiledMap ToTiledMap(this JsonMap jsonMap)
        {
            var tiledMap = new TiledMap();
            tiledMap.Height = jsonMap.Height;
            tiledMap.Width = jsonMap.Width;
            tiledMap.TileWidth = jsonMap.TileWidth;
            tiledMap.TileHeight = jsonMap.TileHeight;
            tiledMap.NextLayerId = jsonMap.NextLayerId;
            tiledMap.NextObjectId = jsonMap.NextObjectId;
            return tiledMap;
        }

        public static TiledLayer ToTiledLayer(this JsonLayer jsonLayer)
        {
            var tiledLayer = new TiledLayer();
            tiledLayer.Data = jsonLayer.Data;
            tiledLayer.Height = jsonLayer.Height;
            tiledLayer.Id = jsonLayer.Id;
            tiledLayer.Name = jsonLayer.Name;
            tiledLayer.Type = jsonLayer.Type;
            tiledLayer.Visible = jsonLayer.Visible;
            tiledLayer.Width = jsonLayer.Width;
            tiledLayer.X = jsonLayer.X;
            tiledLayer.Y = jsonLayer.Y;
            return tiledLayer;
        }

        public static TiledTileSet ToTiledTileSet(this JsonTileSet jsonTileSet)
        {
            var tiledTileSet = new TiledTileSet();
            tiledTileSet.FirstgId = jsonTileSet.FirstgId;
            tiledTileSet.Source = jsonTileSet.Source;
            tiledTileSet.TileSheet = new TiledTileSheet
            {
                Columns = jsonTileSet.TileSheet.Columns,
                Image = jsonTileSet.TileSheet.Image,
                ImageHeight = jsonTileSet.TileSheet.ImageHeight,
                ImageWidth = jsonTileSet.TileSheet.ImageWidth,
                Margin = jsonTileSet.TileSheet.Margin,
                Name = jsonTileSet.TileSheet.Name,
                Spacing = jsonTileSet.TileSheet.Spacing,
                TileCount = jsonTileSet.TileSheet.TileCount,
                TiledVersion = jsonTileSet.TileSheet.TiledVersion,
                TileHeight = jsonTileSet.TileSheet.TileHeight,
                TileWidth = jsonTileSet.TileSheet.TileWidth,
                Type = jsonTileSet.TileSheet.Type,
                Version = jsonTileSet.TileSheet.Version
            };
            if (jsonTileSet.TileSheet.Tiles != null)
            {
                foreach (var jsonTile in jsonTileSet.TileSheet.Tiles)
                {
                    var tile = new TiledTile() { Id = jsonTile.Id };
                    foreach (var jsonAnimation in jsonTile.Animation)
                    {
                        tile.Animation.Add(new TiledAnimation
                        {
                            Duration = jsonAnimation.Duration,
                            TileId = jsonAnimation.TileId
                        });
                    }
                    tiledTileSet.TileSheet.Tiles.Add(tile);
                }
            }
            return tiledTileSet;
        }
    }
}
