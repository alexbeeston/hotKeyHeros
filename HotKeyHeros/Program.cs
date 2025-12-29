using HotKeyHeros;
using HotKeyHeros.Data;

LocalDbContext db = new LocalDbFactory().CreateDbContext(Array.Empty<string>());
await new SharpHookSandbox().RunListener();

