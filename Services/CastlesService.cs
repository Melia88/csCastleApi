using System;
using System.Collections.Generic;
using csCastleApi.Models;
using csCastleApi.Repositories;

namespace csCastleApi.Services
{
  public class CastlesService
  {
    private readonly CastlesRepository _repo;

    public CastlesService(CastlesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Castle> GetAll()
    {
      return _repo.GetAll();
    }
  }
}