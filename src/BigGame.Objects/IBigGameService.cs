using System.Collections.Generic;

namespace BigGame.Objects
{
    public interface IBigGameService
    {
        IEnumerable<Game> GetGames();
        IEnumerable<Score> GetScores(int gameId);
        IEnumerable<Score> GetScores();
        int GetRanking(int gameId);
        bool AddScore(Score score);
    }
}
