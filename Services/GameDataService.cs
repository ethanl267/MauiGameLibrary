using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Services
{
    public class GameDataService
{
    private List<GameInfo> _gameInfo = new List<GameInfo>();

    public List<GameInfo> GetAllGameInfo()
    {
        return _gameInfo;
    }

    public void UpdateGameInfo(GameInfo gameInfo)
    {
         var uniqueGame = GetGameInfoById(gameInfo.Id);


    }

    public GameInfo GetGameInfoById(int id)
    {
       var uniqueGame = _gameInfo.Where(x => x.Id == id).FirstOrDefault();

        return uniqueGame;
    }
    public List<GameInfo> GetGameInfoByTitle(string title)
    {
        return _gameInfo.Where(x => x.Title == title).ToList();
    }

    
}
}
