namespace StoryGame
{
    class Story
    {
        public string Prompt { get; set; }
        public Decision[] Decisions { get; set; }
    }

    class Decision
    {
        public string Route { get; set; }

        public bool IsEnding { get; set; }
        public string Ending { get; set; }

        public string Prompt { get; set; }
        public Decision[] Decisions { get; set; }
    }
}
