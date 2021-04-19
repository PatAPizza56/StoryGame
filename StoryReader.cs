using System;

namespace StoryGame
{
    class StoryReader
    {
        Story story = null;
        public StoryReader(Story story) { this.story = story; }

        public void Start()
        {
            Console.WriteLine(story.Prompt);
            string r = Console.ReadLine();

            for (int i = 0; i < story.Decisions.Length; i++)
            {
                if (r == story.Decisions[i].Route)
                {
                    Prompt(story.Decisions[i]);
                }
            }
        }

        void Prompt(Decision d)
        {
            if (d.IsEnding)
            {
                Console.WriteLine(d.Ending);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(d.Prompt);
                string r = Console.ReadLine();

                for (int i = 0; i < d.Decisions.Length; i++)
                {
                    if (r == d.Decisions[i].Route)
                    {
                        Prompt(d.Decisions[i]);
                    }
                }
            }
        }
    }
}
