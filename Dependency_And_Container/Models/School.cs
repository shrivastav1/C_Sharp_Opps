namespace Dependency.Models
{
    public class School : IEducation
    {
        public void Education(IPerson person)
        {
            Console.WriteLine("Get Education from School");
        }
    }
}