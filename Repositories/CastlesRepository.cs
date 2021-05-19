using System;
using System.Collections.Generic;
using System.Data;
using csCastleApi.Models;
using Dapper;

namespace csCastleApi.Repositories
{
  public class CastlesRepository
  {
    private readonly IDbConnection _db;

    public CastlesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Castle> GetAll()
    {
      // FROM ____ is supposed to be the castles name
      string sql = "SELECT * FROM melias_castle";
      // QUERY returns a collection
      return _db.Query<Castle>(sql);
    }
  }
}