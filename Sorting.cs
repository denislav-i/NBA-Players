namespace NBAPlayers
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Sorting
    {
        public static List<Player> Sort(List<Player> list, int currentYear, int minRating, int maxYearsPlayed)
        {
            List<Player> filteredPlayers = new List<Player>();

            foreach (var player in list.Where(x => x.Rating >= minRating)
        .Where(s => s.PlayingSince >= currentYear - maxYearsPlayed))
            {
                filteredPlayers.Add(player);
            }

            return filteredPlayers = filteredPlayers.OrderByDescending(x => x.Rating).ToList();
        }
    }
}
