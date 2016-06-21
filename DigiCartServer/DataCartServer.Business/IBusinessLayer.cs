using DigiCartServer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCartServer.Business
{
    public interface IBusinessLayer
    {
        IList<Customers> GetAllCustomers();
        Customers GetCustomerByName(string customerName);
        void AddCustomer(params Customers[] customers);
        void UpdateCustomer(params Customers[] customers);
        void RemoveCustomers(params Customers[] customers);

        //Order Interface
    }
}
