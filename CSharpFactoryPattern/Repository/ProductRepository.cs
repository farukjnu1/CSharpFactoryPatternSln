using CSharpFactoryPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Repository
{
    public class ProductRepository: IRepository
    {
        private readonly Dictionary<int, Product> _products = new Dictionary<int, Product>();
        private int _currentId = 1;

        public void Create(IEntity entity)
        {
            var product = entity as Product;
            product.Id = _currentId++;
            _products[product.Id] = product;
        }

        public IEntity Read(int id)
        {
            _products.TryGetValue(id, out var product);
            return product;
        }

        public void Update(IEntity entity)
        {
            var product = entity as Product;
            _products[product.Id] = product;
        }

        public void Delete(int id)
        {
            _products.Remove(id);
        }
    }
}
