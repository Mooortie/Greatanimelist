using System.ComponentModel.DataAnnotations;

namespace Greatanimelist.Server.DataAccess.Models;

public class AnimeModel
{
	public Guid Id { get; set; }

	public string AnimeName { get; set; }

	public int EpisodeCount { get; set; }

	public int SeenEpisodes { get; set; }

}


