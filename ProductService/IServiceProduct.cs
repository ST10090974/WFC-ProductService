using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using ProductService.Models;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceProduct" in both code and config file together.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        List<Product> getProduct();

        [OperationContract]
        void saveProduct(Product p);

        [OperationContract]
        void deleteProduct(string code);

        
    }   
}
