namespace Greatanimelist.Shared;

public record Anime 
{
	public string Name { get; set; }
	public int EpisodeCount { get; set; }
	public int SeenEpisodes { get; set; }

	public Anime (string name, int episodeCount, int seenEpisodes)
	{
		Name = name;
		EpisodeCount = episodeCount;
		SeenEpisodes = seenEpisodes;
	}
}

