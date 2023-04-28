using System;
using System.Collections.Generic;
using ProductService.Models;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceProduct" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceProduct.svc or ServiceProduct.svc.cs at the Solution Explorer and start debugging.
    public class ServiceProduct : IServiceProduct
    {
        public void deleteProduct(string code)
        {
            Product pr = ProductDB.Products.FirstOrDefault(p => p.Code.Equals(code));
            ProductDB.Products.Remove(pr);

        }

        public List<Product> getProduct()
        {
            return ProductDB.Products;
        }

        public void saveProduct(Product p)
        {
            ProductDB.Products.Add(p);
        }
    }
}
