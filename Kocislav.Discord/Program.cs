using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class Program
{
	public static Task Main(string[] args) => new Program().MainAsync();

    private DiscordSocketClient? _client;
    private CommandService? _commandService;

    public async Task MainAsync()
	{
        _client = new DiscordSocketClient();
        _commandService = new CommandService();
        await new CommandHandler(_client, _commandService).InstallCommandsAsync();

        var token = "MTA3NTQ2OTY5Nzc1MzA0Mjk1NA.GCkwgA.BFbjUnT6ZjBUaN52e7pmXSt8XDjpLb7pwDlmR8";
        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();
        await Task.Delay(-1);
    }
}
