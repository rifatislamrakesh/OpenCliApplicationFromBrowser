using CommandLine;
using OpenCliApplicationFromBrowser;

Parser.Default.ParseArguments<Options>(args)
            .WithParsed(OptionService.RunOptions);

Console.ReadLine();