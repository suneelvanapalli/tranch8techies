using DigiCartClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiCartClient.Services
{
    public class ProductService : IProductService
    {
        public bool IsProductExpired(string productID)
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}