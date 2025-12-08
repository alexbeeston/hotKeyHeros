//using SharpHook;

//// ...

//var hook = new EventLoopGlobalHook();

////hook.HookEnabled += OnHookEnabled;     // EventHandler<HookEventArgs>
////hook.HookDisabled += OnHookDisabled;   // EventHandler<HookEventArgs>

//hook.KeyTyped += OnKeyTyped;           // EventHandler<KeyboardHookEventArgs>

//void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
//{
//    Console.WriteLine("Key typed");
//}

////hook.KeyPressed += OnKeyPressed;       // EventHandler<KeyboardHookEventArgs>sdfasdfasdfasdfasdf
////hook.KeyReleased += OnKeyReleased;     // EventHandler<KeyboardHookEventArgs>

//hook.MouseClicked += OnMouseClicked;   // EventHandler<MouseHookEventArgs>

//void OnMouseClicked(object? sender, MouseHookEventArgs e)
//{
//    Console.WriteLine("Mouse clicked");
//}

////hook.MousePressed += OnMousePressed;   // EventHandler<MouseHookEventArgs>
////hook.MouseReleased += OnMouseReleased; // EventHandler<MouseHookEventArgs>
////hook.MouseMoved += OnMouseMoved;       // EventHandler<MouseHookEventArgs>
////hook.MouseDragged += OnMouseDragged;   // EventHandler<MouseHookEventArgs>

////hook.MouseWheel += OnMouseWheel;       // EventHandler<MouseWheelHookEventArgs>

//hook.Run();
//// or
//await hook.RunAsync();

var counter = 0;
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;

while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");

    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}
