using System.Collections;
using System.Collections.Generic;

namespace mvc_test.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product p);
    }
    
}