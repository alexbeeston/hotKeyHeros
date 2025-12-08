using SharpHook;

namespace HotKeyHeros;

public static class SharpHookSandbox
{
    public static void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
    {
        Console.WriteLine("Key typed");
    }

    public static void OnMouseClicked(object? sender, MouseHookEventArgs e)
    {
        Console.WriteLine("Mouse clicked");
    }

    public static async Task Sandbox()
    {
        EventLoopGlobalHook hook = new EventLoopGlobalHook();
        hook.KeyTyped += OnKeyTyped;           // EventHandler<KeyboardHookEventArgs>
        hook.MouseClicked += OnMouseClicked;   // EventHandler<MouseHookEventArgs>
        //hook.HookEnabled += OnHookEnabled;     // EventHandler<HookEventArgs>
        //hook.HookDisabled += OnHookDisabled;   // EventHandler<HookEventArgs>
        //hook.KeyPressed += OnKeyPressed;       // EventHandler<KeyboardHookEventArgs>sdfasdfasdfasdfasdf
        //hook.KeyReleased += OnKeyReleased;     // EventHandler<KeyboardHookEventArgs>
        //hook.MousePressed += OnMousePressed;   // EventHandler<MouseHookEventArgs>
        //hook.MouseReleased += OnMouseReleased; // EventHandler<MouseHookEventArgs>
        //hook.MouseMoved += OnMouseMoved;       // EventHandler<MouseHookEventArgs>
        //hook.MouseDragged += OnMouseDragged;   // EventHandler<MouseHookEventArgs>
        //hook.MouseWheel += OnMouseWheel;       // EventHandler<MouseWheelHookEventArgs>

        //hook.Run();
        // or
        await hook.RunAsync();
    }
}
