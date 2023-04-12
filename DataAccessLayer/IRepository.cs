using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        void Create(T obj);
        void Delete(int id);
        void Update(T obj);
        T GetObject(int id);
        List<T> GetObjects();
    }
}
