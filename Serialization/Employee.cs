namespace C__Course.Serialization
{
    [Serializable]
    public class Employee
    {
        public int Id { get; init; }
        public String FName { get; init; }
        public String LName { get; init; }
        public List<String> Offer { get; init; } = new List<String>();

    }
}
