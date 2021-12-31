namespace OCP
{

    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccountService Proccesor { get; set; }
    }
}