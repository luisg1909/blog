using blog.Interfaces;

namespace blog.Backgrounds
{
    public class AnimeBackground : IBackgroundImage
    {
        public string GetBackground()
        {
            return "Anime Background Image";
        }
    }
}
