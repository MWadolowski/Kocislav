using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class Program
{
	public static Task Main(string[] args) => new Program().MainAsync();

    private DiscordSocketClient? _client;
    private CommandService? _commandService;

    public async Task MainAsync()
	{
        _client = new DiscordSocketClient();
        _commandService = new CommandService();
        new LoggingService(_client, _commandService);
        await new CommandHandler(_client, _commandService).InstallCommandsAsync();
        var token = Environment.GetEnvironmentVariable("token");
        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();
        await Task.Delay(-1);
    }
}
