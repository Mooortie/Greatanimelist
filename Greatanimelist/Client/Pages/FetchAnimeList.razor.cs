using Greatanimelist.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Greatanimelist.Client.Pages;

public partial class FetchAnimeList : ComponentBase
{

	List<Anime> Anime { get; set; } = new();

	Anime CurrentAnime { get; set; } = new("", 0, 0);

	private async Task SaveAnime()
	{
		await _client.PostAsJsonAsync<Anime>("AddAnimes", CurrentAnime);
		var response = await _client.GetFromJsonAsync<IEnumerable<Anime>>("AllAnimes");
		Anime = response.ToList();
		CurrentAnime = new Anime("", 0, 0);
	}
}
