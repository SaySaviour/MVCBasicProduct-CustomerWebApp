using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductServices
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        Product GetById(int? id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
