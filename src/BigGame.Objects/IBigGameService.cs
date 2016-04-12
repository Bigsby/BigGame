using System.Collections.Generic;
using System.Linq;

namespace BigGame.Objects
{
    public interface IBigGameService
    {
        IQueryable<Game> GetGames();
        IQueryable<Score> GetScores(int gameId);
        IQueryable<Score> GetScores();
        int GetRanking(int gameId);
        bool AddScore(Score score);

        IEnumerable<IdentityProvider> GetProviders();
    }
}
