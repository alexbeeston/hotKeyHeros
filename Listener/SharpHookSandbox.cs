using Data;
using SharpHook;

namespace Listener;

public class SharpHookSandbox
{
    public SharpHookSandbox()
    {
        DbContext = new LocalDbFactory().CreateDbContext(Array.Empty<string>());
        UtcLastFlush = DateTime.UtcNow;
        FlusherTask = Task.Run(async () =>
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMinutes(1));
                DateTime utcNow = DateTime.UtcNow;
                var collection = new Data.Models.DataCollectionEntity
                {
                    UtcStart = UtcLastFlush,
                    UtcEnd = utcNow,
                    NumKeyStrokes = KeyStrokesSinceLastFlush,
                    NumMouseClicks = MouseClicksStrokesSinceLastFlush
                };
                DbContext.Collections.Add(collection);
                await DbContext.SaveChangesAsync();
                Console.WriteLine($"Wrote new collection to local db. Key strokes {collection.NumKeyStrokes}. Mouse Clicks: {collection.NumMouseClicks}.");

                KeyStrokesSinceLastFlush = 0;
                MouseClicksStrokesSinceLastFlush = 0;
                UtcLastFlush = utcNow;
            }
        });
    }

    public LocalDbContext DbContext { get; init; }

    private int KeyStrokesSinceLastFlush { get; set; }

    private int MouseClicksStrokesSinceLastFlush { get; set; }

    public DateTime UtcLastFlush { get; set; }

    private Task FlusherTask { get; set; }

    public void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
    {
        KeyStrokesSinceLastFlush++;
    }

    public void OnMouseClicked(object? sender, MouseHookEventArgs e)
    {
        MouseClicksStrokesSinceLastFlush++;
    }

    public async Task RunListener()
    {
        EventLoopGlobalHook hook = new EventLoopGlobalHook();
        hook.KeyTyped += OnKeyTyped;
        hook.MouseClicked += OnMouseClicked;
        await hook.RunAsync();
    }
}
