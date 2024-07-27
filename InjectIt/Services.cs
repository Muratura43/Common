namespace InjectIt
{
    public interface ILogger
    {

    }

    public interface IRepository<T>
    {

    }

    public class SqlServerLogger : ILogger
    {

    }

    public class SqlRepository<T> : IRepository<T>
    {
        public SqlRepository(ILogger logger)
        {

        }
    }

    public class InvoiceService
    {
        public InvoiceService(IRepository<Customer> repository, ILogger logger)
        {

        }
    }
}
