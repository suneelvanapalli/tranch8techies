using DigiCartServer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiCartServer.Domain;

namespace DataCartServer.Business
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;

        public BusinessLayer()
        {
            _customerRepository = new CustomerRepository();
            _orderRepository = new OrderRepository();
        }

        public void AddCustomer(params Customers[] customers)
        {
            _customerRepository.Add(customers);
        }

        public IList<Customers> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customers GetCustomerByName(string customerName)
        {
            return _customerRepository.GetSingle(
                c => c.ContactName.Equals(customerName),
                o => o.Orders);
        }

        public void RemoveCustomers(params Customers[] customers)
        {
            _customerRepository.Remove(customers);
        }

        public void UpdateCustomer(params Customers[] customers)
        {
            _customerRepository.Update(customers);
        }
    }
}
