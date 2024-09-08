using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.FactoryPattern
{
    public class ProductFactory : IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new Product();
        }
    }
}
