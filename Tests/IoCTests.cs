using InjectIt;
using NUnit.Framework.Internal;

namespace Tests
{
    public class IoCTests
    {
        [Test]
        public void CanResolveTypes()
        {
            var container = new Container();
            container.For<InjectIt.ILogger>().Use<SqlServerLogger>();

            var logger = container.Resolve<InjectIt.ILogger>();

            Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());
        }

        [Test]
        public void CanResolveTypesWithoutDefaultConstructor()
        {
            var container = new Container();
            container.For<InjectIt.ILogger>().Use<SqlServerLogger>();
            container.For<IRepository<Employee>>().Use<SqlRepository<Employee>>();

            var repository = container.Resolve<IRepository<Employee>>();

            Assert.AreEqual(typeof(SqlRepository<Employee>), repository.GetType());
        }

        [Test]
        public void CanResolveConcreteTypes()
        {
            var container = new Container();
            container.For<InjectIt.ILogger>().Use<SqlServerLogger>();
            container.For(typeof(IRepository<>)).Use(typeof(SqlRepository<>));

            var service = container.Resolve<InvoiceService>();

            Assert.IsNotNull(service);
        }
    }
}