using blog.Interfaces;

namespace blog.Backgrounds
{
    public class StudentBackground : IBackgroundImage
    {
        public string GetBackground()
        {
            return "Student Background Image";
        }
    }
}
