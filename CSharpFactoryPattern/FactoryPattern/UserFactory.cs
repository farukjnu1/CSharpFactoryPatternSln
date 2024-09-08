using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.FactoryPattern
{
    public class UserFactory: IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new User();
        }
    }
}
