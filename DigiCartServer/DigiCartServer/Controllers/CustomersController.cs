using DataCartServer.Business;
using DigiCartServer.Domain;
using System.Web.Http;
using System.Web.Http.Description;

namespace DigiCartServer.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly IBusinessLayer _businessLayer;

        public CustomersController()
        {
            _businessLayer = new BusinessLayer();
        }

        [ResponseType(typeof(Customers))]
        public IHttpActionResult GetAllCustomers()
        {
            var customers= _businessLayer.GetAllCustomers();
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }
    }
}
