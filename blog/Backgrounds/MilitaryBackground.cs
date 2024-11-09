using blog.Interfaces;

namespace blog.Backgrounds
{
    public class MilitaryBackground : IBackgroundImage
    {
        public string GetBackground()
        {
            return "Military Background Image";
        }
    }
}
