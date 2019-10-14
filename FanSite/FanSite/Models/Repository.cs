using System.Collections.Generic;

namespace FanSite.Models
{
    public static class Repository
    {
        private static List<Story> stories = new List<Story>();

        public static IEnumerable<Story> Stories
        {
            get
            {
                return stories;
            }
        }

        public static void AddStory(Story story)
        {
            stories.Add(story);
        }
    }
}
