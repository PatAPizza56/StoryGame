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
                    Handle(story.Decisions[i]);
                }
            }
        }

        void Handle(Decision d)
        {
            switch (d.Type)
            {
                case (int)Decision.DecisionType.Decision:
                    HandleDecision(d);
                    break;
                //case (int)Decision.DecisionType.Redirect:
                //    for (int i = 0; i < story.Decisions.Length; i++)
                //    {
                //        if (d.ToID == story.Decisions[i].ID)
                //        {
                //            HandleDecision(story.Decisions[i]);
                //        }
                //    }
                //    break;
                case (int)Decision.DecisionType.Ending:
                    HandleEnding(d);
                    break;
            }
        }

        void HandleDecision(Decision d)
        {
            Console.WriteLine(d.Prompt);
            string r = Console.ReadLine();
            for (int i = 0; i < d.Decisions.Length; i++)
            {
                if (r == d.Decisions[i].Route)
                {
                    Handle(d.Decisions[i]);
                }
            }
        }

        void HandleRedirect()
        {

        }

        void HandleEnding(Decision d)
        {
            Console.WriteLine(d.Ending);
            Console.ReadLine();
        }
    }
}
