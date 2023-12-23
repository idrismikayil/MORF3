namespace Domain.Exceptions
{
    public class ConnectionStringNotFound : Exception
    {
        public ConnectionStringNotFound()
        : base("Connection string not found.")
        {
        }
    }
}
