using Greatanimelist.Server.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Greatanimelist.Server.DataAccess;

public class AnimeContext : DbContext
{
	public AnimeContext(DbContextOptions options) : base(options)
	{

	}
	public DbSet<AnimeModel> Anime { get; set; }
}
