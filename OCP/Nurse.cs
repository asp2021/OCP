
namespace OCP
{
     public class Nurse : IApplicant
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public IAccountService Proccesor { get; set; } = new AccountNurse();
    }
}
