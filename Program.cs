using System;
using System.IO;
using Newtonsoft.Json;

namespace StoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryReader story = new StoryReader(JsonConvert.DeserializeObject<Story>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "TheForest.json")));
            story.Start();
        }
    }
}
