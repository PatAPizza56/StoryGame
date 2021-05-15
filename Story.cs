namespace StoryGame
{
    class Story
    {
        public string Prompt { get; set; }
        public Decision[] Decisions { get; set; }
    }

    class Decision
    {
        public enum DecisionType
        {
            Decision = 1,
            Redirect,
            Ending
        }

        // General
        public long ID { get; set; }
        public int Type { get; set; }
        public string Route { get; set; }

        // Decision
        public string Prompt { get; set; }
        public Decision[] Decisions { get; set; }

        // Redirect
        public long ToID { get; set; }

        // Ending
        public string Ending { get; set; }
    }

    // Story routes
    // Common decisions
    // Decision type enum: Redirect, Decision, Ending
    // Access decisions by ID
    // Avoid stack overflow
}
