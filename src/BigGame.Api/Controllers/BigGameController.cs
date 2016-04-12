using BigGame.Objects;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;

namespace BigGame.Api.Controllers
{
    public class BigGameController : ApiController, IBigGameService
    {
        public string Get()
        {
            return "Me here!";
        }

        public bool AddScore(Score score)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Game> GetGames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentityProvider> GetProviders()
        {
            throw new NotImplementedException();
        }

        public int GetRanking(int gameId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Score> GetScores()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Score> GetScores(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}