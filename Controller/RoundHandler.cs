using BattleRoyale;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class RoundHandler
    {
        public static void Round(Map map, int timeout)
        {
            map.Players = map.Players.OrderBy( x => new Random().Next() ).ToList( );
            Console.WriteLine($"\n  Round {map.round_count} : Alive {map.PlayersAlive()}");
            try
            {
                foreach (Player player in map.Players)
                {
                    if (map.IsOver()!=null) {break;}
                    if (player.Health>0)
                    {
                        System.Threading.Thread.Sleep(timeout);
                        map.playerRoam(player);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            map.round_count++;
        }
    }
}
