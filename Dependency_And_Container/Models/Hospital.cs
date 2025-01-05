namespace Dependency.Models
{
    public class Hospital : IHospital
    {
        public void PresonCare(IPerson person)
        {
            Console.WriteLine("Check Your Health Here!");
        }
    }
}