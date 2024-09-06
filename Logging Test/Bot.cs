namespace Logging_Test;

public class Bot : BackgroundService{

    public Bot(ILogger<Bot> logger, DiscordSettings config) {
        
    }
    
    protected override Task ExecuteAsync(CancellationToken stoppingToken) {
        throw new NotImplementedException();
    }
}


public class DiscordSettings {
    public int setting1 { get; set; }
    public int settign2 { get; set; }
}