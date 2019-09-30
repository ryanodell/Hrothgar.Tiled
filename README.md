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

**Coming Soon**
1) Support for loading geometry
2) Support for loading custom properties
3) Provide a way to identify a tiles global ID.
