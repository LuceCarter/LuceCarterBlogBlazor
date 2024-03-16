using LuceCarterWebsite.Models;

namespace LuceCarterWebsite.Services;

public class DadJokeService
{
    private HttpClient _client;
    
    public DadJokeService(HttpClient client)
    {
        _client = client;
    }
    public async Task<string> GetJokeAsync()
    {
        _client.DefaultRequestHeaders.Add("Accept", "application/json");
        _client.DefaultRequestHeaders.Add("User-Agent", "LuceCarterWebsite");

        var joke = await _client.GetFromJsonAsync<DadJokeResponse>("https://icanhazdadjoke.com/");

        return joke.Joke;
    }
}