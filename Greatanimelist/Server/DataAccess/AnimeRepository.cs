using System.Reflection.Metadata.Ecma335;
using Greatanimelist.Server.DataAccess.Models;
using Greatanimelist.Shared;
using System.Reflection.PortableExecutable;
using Greatanimelist.Client.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Greatanimelist.Server.DataAccess;

public class AnimeRepository
{

	private readonly AnimeContext _context;

	public AnimeRepository(AnimeContext context)
	{
		_context = context;
	}

	public void add(Anime newAnime)
	{
		var newAnimeModel = new AnimeModel();

		newAnimeModel.AnimeName = newAnime.Name;
		newAnimeModel.EpisodeCount = newAnime.EpisodeCount;
		newAnimeModel.SeenEpisodes = newAnime.SeenEpisodes;

		_context.Anime.Add(newAnimeModel);
		_context.SaveChanges();
	}

	public IEnumerable<Anime> GetAllAnimes()
	{
		return _context.Anime.Select(am => new Anime
			($"{am.AnimeName}", am.EpisodeCount, am.SeenEpisodes));
	}
}
