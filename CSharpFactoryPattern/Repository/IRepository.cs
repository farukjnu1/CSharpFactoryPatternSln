using CSharpFactoryPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Repository
{
    public interface IRepository
    {
        void Create(IEntity entity);
        IEntity Read(int id);
        void Update(IEntity entity);
        void Delete(int id);
    }
}
