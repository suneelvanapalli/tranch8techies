using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCartClient.Interfaces
{
    public interface IProductService
    {
        bool IsProductExpired(string productID);
    }
}
