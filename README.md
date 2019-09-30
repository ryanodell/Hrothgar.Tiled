# Hrothgar.Tiled
Currently only parses json exports for tiled.
Can be used with Monogame but you are probably better off going with Monogame.Extended.Tiled if you intend to port this to something other than PC.


How to use:

Let's say you have your Json files saved to Content/Raw, you would initialize it as follows:
```
TiledMapLoader tiledMapLoader = new TiledMapLoader(eLoadType.RawJson, "Content/Raw/");

```

Then, you pass in the location of the file and it will parse this out.
```
TiledMap map = tiledMapLoader.LoadMap("test.json");
```

**Note**
Currently, this does not load in geometry. This is only for reading basic map data. Does not currently support custom properties. It does support animation though.
