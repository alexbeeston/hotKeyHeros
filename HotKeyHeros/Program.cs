using HotKeyHeros;
using HotKeyHeros.Data;

LocalDbContext db = new LocalDbFactory().CreateDbContext([""]);
db.Collections.Add(new HotKeyHeros.Data.Models.DataCollectionEntity
{
    UtcStart = DateTime.UtcNow,
    UtcEnd = DateTime.UtcNow.AddHours(1),
    NumKeyStrokes = 100,
    NumMouseClicks = 50
});
db.SaveChanges();
SharpHookSandbox handler = new SharpHookSandbox();
handler.RunListener();

