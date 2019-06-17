using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MovieStore.Core.ServiceCore
{
    public interface ICoreService<T> where T : EntityBase.BaseEntity
    {

        void Add(T item);
        void Add(List<T> items);

        void Update(T item);
        void Remove(T item);

        void Remove(int id);

        void RemoveAll(Expression<Func<T, bool>> exp);

        T GetByID(int id);
        T GetByDefault(Expression<Func<T, bool>> exp);

        List<T> GetActive();
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();

        bool Any(Expression<Func<T, bool>> exp);

        int Save();
    }
}
