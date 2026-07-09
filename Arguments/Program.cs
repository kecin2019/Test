Console.WriteLine("Hello, World!");

WriteLine($"There are {args.Length} arguments.");

if (args.Length == 1 && args[0] is "-h" or "--help")
{
    WriteLine("Usage: dotnet run <foreground> <background> <cursor-size>");
    WriteLine("Example: dotnet run red yellow 50");
    return;
}

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    WriteLine("Run with --help to show usage.");




    
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");


    
    WriteLine("read me and i choose this");
}
