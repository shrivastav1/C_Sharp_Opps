namespace Dependency.Models
{
    public class Collage : IEducation
    {
        public void Education(IPerson person)
        {
            Console.WriteLine("Get Education from Collage");
        }
    }
}