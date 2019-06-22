namespace NBAPlayers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;
            StringBuilder sb = new StringBuilder();

            //User's Input
            string sourceDirectory = Console.ReadLine();
            int maxYearsPlayed = int.Parse(Console.ReadLine());
            int minRating = int.Parse(Console.ReadLine());
            string directoryToSave = Console.ReadLine();

            //Read and Parse JSON
            var reader = new StreamReader(sourceDirectory);
            string json = reader.ReadToEnd();
            List<Player> totalPlayers = JsonConvert.DeserializeObject<List<Player>>(json);

            //Filter and Sort
            List<Player> filteredPlayers = Sorting.Sort(totalPlayers, currentYear, minRating, maxYearsPlayed);

            sb.AppendLine("Name, Rating");

            foreach (var item in filteredPlayers)
            {
                sb.AppendLine($"{item.Name}, {item.Rating}");
            }

            //Generating csv
            File.AppendAllText(directoryToSave, sb.ToString());
        }
    }
}
