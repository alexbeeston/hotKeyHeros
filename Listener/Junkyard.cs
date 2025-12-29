//using App.WindowsService;
//using Microsoft.Extensions.Logging.Configuration;
//using Microsoft.Extensions.Logging.EventLog;

//HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddWindowsService(options =>
//{
//    options.ServiceName = ".NET Joke Service";
//});
//// service URI
//// https://learn.microsoft.com/en-us/dotnet/core/extensions/windows-service
//LoggerProviderOptions.RegisterProviderOptions<
//    EventLogSettings, EventLogLoggerProvider>(builder.Services);

//builder.Services.AddSingleton<JokeService>();
//builder.Services.AddHostedService<WindowsBackgroundService>();

//IHost host = builder.Build();
//host.Run();



//public sealed class JokeService
//{
//    public string GetJoke()
//    {
//        Joke joke = _jokes.ElementAt(
//            Random.Shared.Next(_jokes.Count));

//        return $"{joke.Setup}{Environment.NewLine}{joke.Punchline}";
//    }

//    private readonly HashSet<Joke> _jokes = new()
//    {
//        new Joke("What's the best thing about a Boolean?", "Even if you're wrong, you're only off by a bit."),
//        new Joke("What's the object-oriented way to become wealthy?", "Inheritance"),
//        new Joke("Why did the programmer quit their job?", "Because they didn't get arrays."),
//        new Joke("Why do programmers always mix up Halloween and Christmas?", "Because Oct 31 == Dec 25"),
//        new Joke("How many programmers does it take to change a lightbulb?", "None that's a hardware problem"),
//        new Joke("If you put a million monkeys at a million keyboards, one of them will eventually write a Java program", "the rest of them will write Perl"),
//        new Joke("['hip', 'hip']", "(hip hip array)"),
//        new Joke("To understand what recursion is...", "You must first understand what recursion is"),
//        new Joke("There are 10 types of people in this world...", "Those who understand binary and those who don't"),
//        new Joke("Which song would an exception sing?", "Can't catch me - Avicii"),
//        new Joke("Why do Java programmers wear glasses?", "Because they don't C#"),
//        new Joke("How do you check if a webpage is HTML5?", "Try it out on Internet Explorer"),
//        new Joke("A user interface is like a joke.", "If you have to explain it then it is not that good."),
//        new Joke("I was gonna tell you a joke about UDP...", "...but you might not get it."),
//        new Joke("The punchline often arrives before the set-up.", "Do you know the problem with UDP jokes?"),
//        new Joke("Why do C# and Java developers keep breaking their keyboards?", "Because they use a strongly typed language."),
//        new Joke("Knock-knock.", "A race condition. Who is there?"),
//        new Joke("What's the best part about TCP jokes?", "I get to keep telling them until you get them."),
//        new Joke("A programmer puts two glasses on their bedside table before going to sleep.", "A full one, in case they gets thirsty, and an empty one, in case they don’t."),
//        new Joke("There are 10 kinds of people in this world.", "Those who understand binary, those who don't, and those who weren't expecting a base 3 joke."),
//        new Joke("What did the router say to the doctor?", "It hurts when IP."),
//        new Joke("An IPv6 packet is walking out of the house.", "He goes nowhere."),
//        new Joke("3 SQL statements walk into a NoSQL bar. Soon, they walk out", "They couldn't find a table.")
//    };
//}

//readonly record struct Joke(string Setup, string Punchline);


    //public async Task RunListener()
    //{
    //    EventLoopGlobalHook hook = new EventLoopGlobalHook();
    //    hook.KeyTyped += OnKeyTyped;           // EventHandler<KeyboardHookEventArgs>
    //    hook.MouseClicked += OnMouseClicked;   // EventHandler<MouseHookEventArgs>
    //    //hook.HookEnabled += OnHookEnabled;     // EventHandler<HookEventArgs>
    //    //hook.HookDisabled += OnHookDisabled;   // EventHandler<HookEventArgs>
    //    //hook.KeyPressed += OnKeyPressed;       // EventHandler<KeyboardHookEventArgs>sdfasdfasdfasdfasdf
    //    //hook.KeyReleased += OnKeyReleased;     // EventHandler<KeyboardHookEventArgs>
    //    //hook.MousePressed += OnMousePressed;   // EventHandler<MouseHookEventArgs>
    //    //hook.MouseReleased += OnMouseReleased; // EventHandler<MouseHookEventArgs>
    //    //hook.MouseMoved += OnMouseMoved;       // EventHandler<MouseHookEventArgs>
    //    //hook.MouseDragged += OnMouseDragged;   // EventHandler<MouseHookEventArgs>
    //    //hook.MouseWheel += OnMouseWheel;       // EventHandler<MouseWheelHookEventArgs>

    //    //hook.Run();
    //    // or
    //    await hook.RunAsync();
    //}


//public sealed class WindowsBackgroundService(
//    JokeService jokeService,
//    ILogger<WindowsBackgroundService> logger) : BackgroundService
//{
//    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//    {
//        try
//        {
//            while (!stoppingToken.IsCancellationRequested)
//            {
//                string joke = jokeService.GetJoke();
//                logger.LogWarning("{Joke}", joke);

//                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
//            }
//        }
//        catch (OperationCanceledException)
//        {
//            // When the stopping token is canceled, for example, a call made from services.msc,
//            // we shouldn't exit with a non-zero exit code. In other words, this is expected...
//        }
//        catch (Exception ex)
//        {
//            logger.LogError(ex, "{Message}", ex.Message);

//            // Terminates this process and returns an exit code to the operating system.
//            // This is required to avoid the 'BackgroundServiceExceptionBehavior', which
//            // performs one of two scenarios:
//            // 1. When set to "Ignore": will do nothing at all, errors cause zombie services.
//            // 2. When set to "StopHost": will cleanly stop the host, and log errors.
//            //
//            // In order for the Windows Service Management system to leverage configured
//            // recovery options, we need to terminate the process with a non-zero exit code.
//            Environment.Exit(1);
//        }
//    }
//}
