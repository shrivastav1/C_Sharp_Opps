namespace Dependency.Models
{
    public class Home : IHome
    {
        public void ProvideRest(IPerson person)
        {
            Console.WriteLine("Rest at Home");
        }
    }
}