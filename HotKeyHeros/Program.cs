using Data;
using Listener;

LocalDbContext db = new LocalDbFactory().CreateDbContext(Array.Empty<string>());
await new SharpHookSandbox().RunListener();

