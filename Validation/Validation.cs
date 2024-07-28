public class DomainExptionValidation : Exception
{
    public DomainExptionValidation(string error) : base(error)
    {
    }
    public static void When(bool hasError, string error)
    {
        if (hasError)
        {
            throw new DomainExptionValidation(error);
        }
    }
}