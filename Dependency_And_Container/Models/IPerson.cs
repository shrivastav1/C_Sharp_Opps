namespace Dependency.Models
{
    public interface IPerson
    {
        IEducation School { set; }
        void TakeRest();

        void GetEducation();

        void TakeCare(IHospital hospital);
    }
}