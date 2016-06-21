using DigiCartServer.Domain;

namespace DigiCartServer.DataAccess
{
    public interface ICustomerRepository:IGenericDataRepository<Customers>
    {
    }

    public interface IOrderRepository : IGenericDataRepository<Orders>
    {

    }

    public class CustomerRepository : GenericDataRepository<Customers>, ICustomerRepository
    {

    }

    public class OrderRepository : GenericDataRepository<Orders>, IOrderRepository
    {

    }

}
