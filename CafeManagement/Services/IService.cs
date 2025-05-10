using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Services
{
    internal interface IService<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetById(Guid id);
        List<T> GetAll();
        List<T> Search(string keyword);
    }
}
